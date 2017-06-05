using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;
namespace KP_SPZ_Sribna
{
    class listenerSerialPort : SerialPort
    {
        private readonly int dataSize = 54;
        private byte[] buffer;
        private int stepIndex;
        private bool startRead;
        private string port;

        public listenerSerialPort(string port, int dataSize = 54)
            : base()
        {
            this.port = port;
            this.dataSize = dataSize;
            buffer = new byte[dataSize];
            base.PortName = port;
            base.BaudRate = 9600;
            base.DataBits = 8;
            base.StopBits = StopBits.Two;
            base.Parity = Parity.None;
            base.ReadTimeout = 1000;
            base.DataReceived += SerialProtDataReceived;
        }


        public void Open(string portName)
        {
            if (base.IsOpen)
            {
                base.Close();
            }
            base.PortName = portName;
            base.Open();
        }

        private void SerialProtDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var port = (SerialPort)sender;
            try
            {
                int bufferSize = port.BytesToRead;
                for (int i = 0; i < bufferSize; ++i)
                {
                    byte bt = (byte)port.ReadByte();
                    if (0xFF == bt)
                    {
                        stepIndex = 0;
                        startRead = true;
                    }

                    if (startRead)
                    {
                        buffer[stepIndex] = bt;
                        ++stepIndex;
                    }

                    if (stepIndex == dataSize && startRead)
                    {
                        WriteAllData(buffer);
                        startRead = false;
                    }
                }
            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message);
            }

        }

        private void WriteAllData(byte[] buff)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("log.bin", FileMode.Create)))
            {
                for (int i = 0; i < buffer.Length; ++i)
                {
                    bw.Write(buff[i]);
                }
            }
        }
    }
}
