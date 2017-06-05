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
                //cbBoudRate.se
            };
        }



        private void cbSelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
