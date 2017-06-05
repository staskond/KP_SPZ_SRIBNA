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
        public Form1()
        {
            InitializeComponent();
            //byte[] aaa = new byte[28];
            //SerialPort bbb = new SerialPort("COM1");
            //bbb.Open();
            //bbb.Read(aaa, 4, 32);
            cbSelectCOM.Items.AddRange(SerialPort.GetPortNames());//отображаем количество возможных портов
        }


        private void cbSelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
