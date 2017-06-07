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
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

//virtualSerialPortDriver
namespace KP_SPZ_Sribna
{
    public partial class Form1 : Form
    {
        Series ChartZeroSer, ChartOneSer, ChartMaxZeroBit, ChartMaxOneBit;
        public Form1()
        {
            #region InitializeComponent
            InitializeComponent();
            SerialPort SP = new SerialPort();//инициализация объекта SerialPort
            SP.DataReceived += EventCom;//подписка нашей функции на событие прихода данных в порт
            this.chart1.Palette = ChartColorPalette.SeaGreen;//устанавливаем цвет графика
            this.chart1.Series.RemoveAt(0);// удаляем созданный по умолчанию элемент
            this.chart2.Titles.Add("Maximus sequence of bits.");//устанавливаем название графика
            this.chart2.Series.RemoveAt(0);// удаляем созданный по умолчанию элемент
            this.chart1.Titles.Add("Bits");//устанавливаем название графика
            //добавляем столбцы которые будут отображаться на диаграмме
            ChartZeroSer = this.chart1.Series.Add("Nums of Zero bits");
            ChartOneSer = this.chart1.Series.Add("Nums of one bits");
            ChartMaxOneBit = this.chart2.Series.Add("Max seq one bits.");
            ChartMaxZeroBit = this.chart2.Series.Add("Max Seq zero bits.");

            cbreg.Items.Add("Строка");
            cbreg.Items.Add("Буффер");
            cbreg.SelectedIndex = 0;

            cbSelectCOM.Items.AddRange(SerialPort.GetPortNames());//добавляем возможные порты в comboBox
            cbSelectCOM.SelectedIndex = 0;//устанавливаем индекс элемента по умолчанию
            //поштучно добавляем все элементы в comboBox предназначенный для выбора скорости передачи
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
            cbBoudRate.SelectedIndex = 7;//устанавливаем элемент заданный по умолчанию
            
            cbByteSize.Items.Add("5");
            cbByteSize.Items.Add("6");
            cbByteSize.Items.Add("7");
            cbByteSize.Items.Add("8");
            cbByteSize.SelectedIndex = 3;

            cbStopBit.Items.Add("1");
            cbStopBit.Items.Add("2");
            cbStopBit.SelectedIndex = 0;

            cbParity.Items.Add("отсутствует");
            cbParity.Items.Add("четный");
            cbParity.Items.Add("нечетный");
            cbParity.SelectedIndex = 0;
#endregion InitializeComponent

            btConnect.Click += (object sender, EventArgs e) =>
            {
                
                try
                {
                    #region CheckToCorrectValue
                    if (!(cbSelectCOM.Text.Equals("")))//проверяем наличия значение в comboBox для выбора порта
                    {
                        SP.PortName = cbSelectCOM.Text;//устанавливаем значение в свойство PortName из comboBox
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
                    else if (cbStopBit.Text.Equals("2"))
                    {
                        SP.StopBits = StopBits.Two;
                    }
                    else SP.StopBits = StopBits.None;
                    
                    SP.ReadBufferSize = Convert.ToInt32(nud_BufferSize.Value);//устанавливаем размер буфера для считывания из формы domainUpDown
#endregion CheckCorrectValue
                    BlockControllView(false);
                    SP.Open();
                }
                catch(ArgumentException e1)//ловим исключение
                {
                    if (SP.IsOpen)//если у нас порт открыт, то мы должны его закрыть
                    {
                        SP.Close();//закрываем порт
                    }
                    BlockControllView(true);//разблокируем элементы управления
                    MessageBox.Show(e1.Message);//выводим информацию об ошибке
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
                if (SP.IsOpen)//проверяем, открыт ли порт
                {
                    SP.Close();//закрываем порт
                }
                BlockControllView(true);//разблокируем управляющие элементы
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
            cbreg.Enabled = val;
        }

        private void cbSelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EventCom(object sender, EventArgs e)
        {
            try
            {
                #region readData
                string ReadData = "";
                SerialPort port = (SerialPort)sender;//копируем данные из отправителя
                List<int> bitValToInt = new List<int>();//коллекция интов для хранения всех битовых значений
                List<char> bitValInCharList = new List<char>();//коллекция чаров для хранения данных переведенных из строки в битовом формате
                StringBuilder sb = new StringBuilder();
                if (cbreg.Text.Equals("Строка"))
                {
                    ReadData = port.ReadLine();//port.ReadExisting();//считываем данные пришедшие в порт
                }
                else ReadData = port.ReadExisting();
                if (ReadData.Length > nud_BufferSize.Value)//проверяем, если количество символов в пришедшей стоке больше чем максимальный размер пакета
                {
                    ReadData = ReadData.Substring(0, Convert.ToInt32(nud_BufferSize.Value));//то обрезаем строку
                }
                foreach (byte b in Encoding.Unicode.GetBytes(ReadData))//преобразовуем полученную строку
                    sb.Append(Convert.ToString(b, 2));//в строку байт
                //bitValToInt.Clear();//отчищаем массив интов
                string tempString = sb.ToString();//записываем данные из объекта StringBuilder в обычную строку для дальнейших манипуляций
                bitValInCharList.AddRange(tempString.ToCharArray());//преобразуем полученную байтовую строку в массив чаров и записываем его в коллекцию чаров

                foreach (char v in bitValInCharList)//преобразуем каждый отдельный элемент коллекции чарров
                {//в int и записываем в коллекцию ont для дальнейших манипуляций
                    if (v == '0')//если элемент коллекции равен 0
                    {
                        bitValToInt.Add(0);//добавляем в коллекцию интов 0
                    }
                    else bitValToInt.Add(1);//если равен 1, то добавляем в коллекцию интов 1
                }
                #endregion readData

                // port.Close();
                #region setDataToWindow
                rtb_DataString.Text = ReadData;//присваиваем элементу отображения данные которые мы считали из порта
                rtb_DataBit.Text = tempString;//присваиваем другому элементу отображения данные в битовом формате
                StringBuilder rtb_string = new StringBuilder();//создаем новый экземпляр StringBuilder
                rtb_string.Append("Количество единичных бит: ");//добавляем в конец элемента StringBuilder строку
                rtb_string.Append(GetCountBit(ref bitValToInt, 1).ToString());//вызываем функцию для считывания количества единичных бит и добавления результата в конец строки
                rtb_string.Append("\nКоличество нулевых бит: ");
                rtb_string.Append(GetCountBit(ref bitValToInt, 0).ToString());
                rtb_string.Append("\nМаксимальная последовательность нулевых бит: ");
                rtb_string.Append(GetMaxBitSequence(ref bitValToInt, 0).ToString());
                rtb_string.Append("\nМаксимальная последовательность единичных бит: ");
                rtb_string.Append(GetMaxBitSequence(ref bitValToInt, 1).ToString());
                rtb_string.Append("\nСреднее арифметическое всех бит: ");
                rtb_string.Append(GetAverage(ref bitValToInt).ToString());
                rtb_output.Text = rtb_string.ToString();
                WriteToFile(ReadData, tempString, rtb_string.ToString());
                //BlockControllView(true);
                //MessageBox.Show("Пакет данных успешно принят");
                ChartZeroSer.Points.Clear();//очищаем данные графика
                ChartMaxZeroBit.Points.Clear();
                ChartMaxOneBit.Points.Clear();
                ChartOneSer.Points.Clear();
                ChartZeroSer.Points.Add(GetCountBit(ref bitValToInt, 0));//добавляем новые данные(точки, значения) графика
                ChartOneSer.Points.Add(GetCountBit(ref bitValToInt, 1));
                ChartMaxZeroBit.Points.Add(GetMaxBitSequence(ref bitValToInt, 0));
                ChartMaxOneBit.Points.Add(GetMaxBitSequence(ref bitValToInt, 1));
                #endregion setDataToWindow
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                
            }

        }

        private int GetMaxBitSequence(ref List<int> val, int value)//функция для получения максимальной последовательности нулевых бит
        {
            int now = 0;//переменная для хранения текущего значения текущее значение
            int max = 1;//переменная для хранения максимального значения
            foreach(int a in val)
            {
                if (a == value)
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


        private int GetCountBit(ref List<int> val, int value)
        {
            int result = 0;
            foreach (int a in val)
            {
                if (a == value)
                    result += 1;
            }
            return result;
        }

        private double GetAverage(ref List <int>val)//получение среднего арифметического в последовательности бит
        {
            int tmp = 0; //переменная для суммы всех значений
            foreach(int a in val)//суммируем все значения в цикле
            {
                tmp += a;
            }
            //умнажаем на большее 1000000 для того чтобы поделить на меньшее.
            //Если мы поделем большее число на меньшее то в результате получим 0
            //а таким образом мы получем нормальное значение после обратного деления на 10000000
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
