﻿namespace KP_SPZ_Sribna
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
            this.nud_BufferSize = new System.Windows.Forms.NumericUpDown();
            this.rtb_DataString = new System.Windows.Forms.RichTextBox();
            this.rtb_DataBit = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.btConnect.Location = new System.Drawing.Point(11, 190);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(216, 23);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Подключится";
            this.btConnect.UseVisualStyleBackColor = true;
            // 
            // btDiconnect
            // 
            this.btDiconnect.Location = new System.Drawing.Point(11, 219);
            this.btDiconnect.Name = "btDiconnect";
            this.btDiconnect.Size = new System.Drawing.Size(216, 23);
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
            // nud_BufferSize
            // 
            this.nud_BufferSize.Location = new System.Drawing.Point(111, 154);
            this.nud_BufferSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nud_BufferSize.Minimum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.nud_BufferSize.Name = "nud_BufferSize";
            this.nud_BufferSize.Size = new System.Drawing.Size(120, 20);
            this.nud_BufferSize.TabIndex = 12;
            this.nud_BufferSize.Value = new decimal(new int[] {
            54,
            0,
            0,
            0});
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
            this.rtb_DataBit.Size = new System.Drawing.Size(346, 52);
            this.rtb_DataBit.TabIndex = 14;
            this.rtb_DataBit.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(237, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 36);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 254);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtb_DataBit);
            this.Controls.Add(this.rtb_DataString);
            this.Controls.Add(this.nud_BufferSize);
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
        private System.Windows.Forms.NumericUpDown nud_BufferSize;
        private System.Windows.Forms.RichTextBox rtb_DataString;
        private System.Windows.Forms.RichTextBox rtb_DataBit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

