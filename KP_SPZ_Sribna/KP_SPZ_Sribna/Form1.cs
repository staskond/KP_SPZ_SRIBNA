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

//virtualSerialPortDriver
namespace KP_SPZ_Sribna
{
    public partial class Form1 : Form
    {
        
        string stroka = "";
        public Form1()
        {
            InitializeComponent();
            //byte[] aaa = new byte[28];
            //SerialPort bbb = new SerialPort("COM1");
            //bbb.Open();
            //bbb.Read(aaa, 4, 32);
            SerialPort serialPort1 = new SerialPort();
            serialPort1.PortName = "COM1"; //Указываем наш порт - в данном случае COM1.
            serialPort1.BaudRate = 9600; //указываем скорость.
            serialPort1.DataBits = 8;
            serialPort1.Open(); //Открываем порт.
            cbSelectCOM.Items.AddRange(SerialPort.GetPortNames());//отображаем количество возможных портов
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate));
        }
        private void DoUpdate(object s, EventArgs e)
        {
            stroka = stroka + serialPort1.ReadExisting();
        }


        private void cbSelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
