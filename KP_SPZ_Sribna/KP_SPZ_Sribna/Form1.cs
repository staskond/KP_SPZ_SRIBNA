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
            
        }

    }
}
