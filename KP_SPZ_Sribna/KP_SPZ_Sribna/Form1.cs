using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;

//virtualSerialPortDriver
namespace KP_SPZ_Sribna
{
    public partial class Form1 : Form
    {
        
        List<byte> buffer = new List<byte>();
        public Form1()
        {
            InitializeComponent();
            SerialPort SP = new SerialPort();
            //SP.PortName = "COM1";
            //SP.Open();
            //nupSizeDataBlock.Value = 256;
            SP.DataReceived += EventCom;
            cbSelectCOM.Items.AddRange(SerialPort.GetPortNames());//отображаем количество возможных портов
            cbSelectCOM.SelectedIndex = 0;
            cbBoudRate.Items.Add("50");
            cbBoudRate.Items.Add("75");
            cbBoudRate.Items.Add("150");
            cbBoudRate.Items.Add("300");
            cbBoudRate.Items.Add("1200");
            cbBoudRate.Items.Add("2400");
            cbBoudRate.Items.Add("4800");
            cbBoudRate.Items.Add("9600");
            cbBoudRate.Items.Add("19200");
            cbBoudRate.Items.Add("38400");
            cbBoudRate.Items.Add("57600");
            cbBoudRate.Items.Add("115200");
            cbBoudRate.SelectedIndex = 7;

            cbByteSize.Items.Add("5");
            cbByteSize.Items.Add("6");
            cbByteSize.Items.Add("7");
            cbByteSize.Items.Add("8");
            cbByteSize.SelectedIndex = 3;

            cbStopBit.Items.Add("1");
            cbStopBit.Items.Add("1.5");
            cbStopBit.Items.Add("2");
            cbStopBit.SelectedIndex = 0;

            cbParity.Items.Add("отсутствует");
            cbParity.Items.Add("четный");
            cbParity.Items.Add("нечетный");
            cbParity.SelectedIndex = 0;

            btConnect.Click += (object sender, EventArgs e) =>
            {
                
                try
                {
                    if (!(cbSelectCOM.Text.Equals("")))
                    {
                        SP.PortName = cbSelectCOM.Text;
                    }
                    else
                    {
                        throw new ArgumentException("Недопустимое значение com порта");
                    }

                    if (!(cbBoudRate.Text.Equals("")))
                    {
                        SP.BaudRate = Convert.ToInt32(cbBoudRate.Text);
                    }
                    else
                    {
                        throw new ArgumentException("Недопустимое значение скорости передачи данных.");
                    }

                    if (cbParity.Text.Equals("отсутствует"))
                    {
                        SP.Parity = Parity.None;
                    }
                    else if (cbParity.Text.Equals("четный"))
                    {
                        SP.Parity = Parity.Even;
                    }
                    else if (cbParity.Text.Equals("нечетный"))
                    {
                        SP.Parity = Parity.Odd;
                    }
                    else SP.Parity = Parity.None;

                    if (!(cbByteSize.Text.Equals("")))
                    {
                        SP.DataBits = Convert.ToInt32(cbByteSize.Text);
                    }
                    else
                    {
                        throw new ArgumentException("Недопустимое значение количества бит");
                    }


                    if (cbStopBit.Text.Equals("1"))
                    {
                        SP.StopBits = StopBits.One;
                    }
                    else if (cbStopBit.Text.Equals("1.5"))
                    {
                        SP.StopBits = StopBits.OnePointFive;
                    }
                    else if (cbStopBit.Text.Equals("2"))
                    {
                        SP.StopBits = StopBits.Two;
                    }
                    else SP.StopBits = StopBits.None;

                    SP.ReadBufferSize = Convert.ToInt32(nud_BufferSize.Value);

                    BlockControllView(false);
                    SP.Open();
                }
                catch(ArgumentException e1)
                {
                    if (SP.IsOpen)
                    {
                        SP.Close();
                    }
                    BlockControllView(true);
                    MessageBox.Show(e1.Message);
                }
                catch(Exception e2)
                {
                    if (SP.IsOpen)
                    {
                        SP.Close();
                    }
                    BlockControllView(true);
                    MessageBox.Show(e2.Message);
                }
                finally
                {
                    //SP.Close();
                }
            };
            btDiconnect.Click += (object sender, EventArgs e) =>
            {
                if (SP.IsOpen)
                {
                    SP.Close();
                }
                BlockControllView(true);
            };

        }

        private void BlockControllView(bool val)
        {
            cbByteSize.Enabled = val;
            cbParity.Enabled = val;
            cbSelectCOM.Enabled = val;
            cbStopBit.Enabled = val;
            cbBoudRate.Enabled = val;
            btConnect.Enabled = val;
            nud_BufferSize.Enabled = val;
        }

        private void cbSelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EventCom(object sender, EventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            List<int> bitValToInt = new List<int>();
            List<char> bitValInCharList = new List<char>();
            StringBuilder sb = new StringBuilder();
            string ReadDate = port.ReadExisting();
            foreach (byte b in Encoding.Unicode.GetBytes(ReadDate))
                sb.Append(Convert.ToString(b, 2));
            bitValToInt.Clear();
            string tempString = sb.ToString(); 
            bitValInCharList.AddRange(tempString.ToCharArray());
            foreach(char v in bitValInCharList)
            {
                if (v == '0')
                {
                    bitValToInt.Add(0);
                }
                else bitValToInt.Add(1);
            }
            port.Close();
            rtb_DataString.Text = ReadDate;
            rtb_DataBit.Text = tempString;
            StringBuilder rtb_string = new StringBuilder();
            rtb_string.Append("Количество единичных бит: ");
            rtb_string.Append(GetCounOneBit(ref bitValToInt).ToString());
            rtb_string.Append("\nКоличество нулевых бит: ");
            rtb_string.Append(GetCounOneBit(ref bitValToInt).ToString());
            rtb_string.Append("\nМаксимальная последовательность нулевых бит: ");
            rtb_string.Append(GetMaxZeroBitSequence(ref bitValToInt).ToString());
            rtb_string.Append("\nМаксимальная последовательность единичных бит: ");
            rtb_string.Append(GetMaxSingleBitSequence(ref bitValToInt).ToString());
            rtb_string.Append("\nСреднее арифметическое всех бит: ");
            rtb_string.Append(GetAverage(ref bitValToInt).ToString());
            rtb_output.Text = rtb_string.ToString();
            WriteToFile(ReadDate, tempString , rtb_string.ToString());
            BlockControllView(true);
            MessageBox.Show("Пакет данных успешно принят");

        }

        private int GetMaxZeroBitSequence(ref List<int> val)
        {
            int now = 0;
            int max = 1;
            foreach(int a in val)
            {
                if (a == 0)
                {
                    now += 1;
                    if (now > max)
                    {
                        max = now;
                    }
                }
                else now = 0;
            }
            return max;
        }

        private int GetMaxSingleBitSequence(ref List<int> val)
        {
            int now = 0;
            int max = 1;
            foreach(int a in val)
            {
                if (a == 1)
                {
                    now += 1;
                    if (now > max)
                    {
                        max = now;
                    }
                }
                else now = 0;
            }
            return max;
        }

        private int GetCounZeroBit(ref List<int> val)
        {
            int result = 0;
            foreach (int a in val)
            {
                if (a == 0)
                    result += 1;
            }
            return result;
        }

        private int GetCounOneBit(ref List<int> val)
        {
            int result = 0;
            foreach(int a in val)
            {
                if (a == 0)
                    result += 1;
            }
            return result;
        }

        private double GetAverage(ref List <int>val)
        {
            int tmp = 0; 
            foreach(int a in val)
            {
                tmp += a;
            }
            double tmp1 = ((tmp*1000000) / val.Count);
            tmp1 = tmp1 / 1000000;
            return tmp1;
        }

        private void WriteToFile(string originalData, string BitData, string output)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("readData.txt", false, System.Text.Encoding.Default))
                {
                    sw.Write(originalData);
                }
                using (StreamWriter sw = new StreamWriter("bitData.txt", false, System.Text.Encoding.Default))
                {
                    sw.Write(BitData);
                }
                using (StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.Default))
                {
                    sw.Write(output);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
