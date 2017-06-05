namespace KP_SPZ_Sribna
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbSelectCOM = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbByteSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDiconnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.rtb_DataString = new System.Windows.Forms.RichTextBox();
            this.rtb_DataBit = new System.Windows.Forms.RichTextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nud_BufferSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BufferSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectCOM
            // 
            this.cbSelectCOM.FormattingEnabled = true;
            this.cbSelectCOM.Location = new System.Drawing.Point(110, 12);
            this.cbSelectCOM.Name = "cbSelectCOM";
            this.cbSelectCOM.Size = new System.Drawing.Size(121, 21);
            this.cbSelectCOM.TabIndex = 0;
            this.cbSelectCOM.SelectedIndexChanged += new System.EventHandler(this.cbSelectCOM_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скорость: ";
            // 
            // cbBoudRate
            // 
            this.cbBoudRate.FormattingEnabled = true;
            this.cbBoudRate.Location = new System.Drawing.Point(110, 39);
            this.cbBoudRate.Name = "cbBoudRate";
            this.cbBoudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBoudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Размер байта: ";
            // 
            // cbByteSize
            // 
            this.cbByteSize.FormattingEnabled = true;
            this.cbByteSize.Location = new System.Drawing.Point(110, 69);
            this.cbByteSize.Name = "cbByteSize";
            this.cbByteSize.Size = new System.Drawing.Size(121, 21);
            this.cbByteSize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоп битов: ";
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Location = new System.Drawing.Point(110, 100);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(121, 21);
            this.cbStopBit.TabIndex = 7;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(11, 192);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(216, 23);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Подключится";
            this.btConnect.UseVisualStyleBackColor = true;
            // 
            // btDiconnect
            // 
            this.btDiconnect.Location = new System.Drawing.Point(11, 221);
            this.btDiconnect.Name = "btDiconnect";
            this.btDiconnect.Size = new System.Drawing.Size(216, 21);
            this.btDiconnect.TabIndex = 9;
            this.btDiconnect.Text = "Отключится";
            this.btDiconnect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Паритет: ";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(110, 127);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 11;
            // 
            // rtb_DataString
            // 
            this.rtb_DataString.Location = new System.Drawing.Point(237, 21);
            this.rtb_DataString.Name = "rtb_DataString";
            this.rtb_DataString.Size = new System.Drawing.Size(346, 48);
            this.rtb_DataString.TabIndex = 13;
            this.rtb_DataString.Text = "";
            // 
            // rtb_DataBit
            // 
            this.rtb_DataBit.Location = new System.Drawing.Point(237, 88);
            this.rtb_DataBit.Name = "rtb_DataBit";
            this.rtb_DataBit.Size = new System.Drawing.Size(346, 60);
            this.rtb_DataBit.TabIndex = 14;
            this.rtb_DataBit.Text = "";
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(237, 170);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(346, 72);
            this.rtb_output.TabIndex = 15;
            this.rtb_output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "№ COM порта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Принятые данные:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Принятые данные в двоичном формате:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Вывод: ";
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(11, 256);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(272, 221);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(315, 256);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(268, 221);
            this.chart2.TabIndex = 21;
            this.chart2.Text = "chart2";
            // 
            // nud_BufferSize
            // 
            this.nud_BufferSize.Location = new System.Drawing.Point(111, 154);
            this.nud_BufferSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nud_BufferSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_BufferSize.Name = "nud_BufferSize";
            this.nud_BufferSize.Size = new System.Drawing.Size(120, 20);
            this.nud_BufferSize.TabIndex = 22;
            this.nud_BufferSize.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Блок данных: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 489);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nud_BufferSize);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtb_DataBit);
            this.Controls.Add(this.rtb_DataString);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btDiconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbStopBit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbByteSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBoudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectCOM);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BufferSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectCOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbByteSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDiconnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.RichTextBox rtb_DataString;
        private System.Windows.Forms.RichTextBox rtb_DataBit;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.NumericUpDown nud_BufferSize;
        private System.Windows.Forms.Label label9;
    }
}

