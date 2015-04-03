namespace CsvTo1C.WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SkipFirstNRowsEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DelimiterEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DoneLabel = new System.Windows.Forms.Label();
            this.TransitBillTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Помчали!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text documents (.csv)|*.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите файл .csv, импортированный из банка. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Программа создаст файл в той же папке но в формате .txt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обзор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(24, 293);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(358, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Удалить первую строчку в файле? (Альфа создает одну лишнюю)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SkipFirstNRowsEdit
            // 
            this.SkipFirstNRowsEdit.Location = new System.Drawing.Point(24, 367);
            this.SkipFirstNRowsEdit.Name = "SkipFirstNRowsEdit";
            this.SkipFirstNRowsEdit.Size = new System.Drawing.Size(53, 20);
            this.SkipFirstNRowsEdit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пропустить первые N строчек в выписке (Для Альфа-банка первая строчка лишняя)";
            // 
            // DelimiterEdit
            // 
            this.DelimiterEdit.Location = new System.Drawing.Point(24, 325);
            this.DelimiterEdit.Name = "DelimiterEdit";
            this.DelimiterEdit.Size = new System.Drawing.Size(100, 20);
            this.DelimiterEdit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Разделитель";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(220, 328);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(13, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DoneLabel
            // 
            this.DoneLabel.AutoSize = true;
            this.DoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.DoneLabel.Location = new System.Drawing.Point(128, 402);
            this.DoneLabel.Name = "DoneLabel";
            this.DoneLabel.Size = new System.Drawing.Size(121, 18);
            this.DoneLabel.TabIndex = 11;
            this.DoneLabel.Text = "Готово, котаны!";
            // 
            // TransitBillTextBox
            // 
            this.TransitBillTextBox.Location = new System.Drawing.Point(24, 219);
            this.TransitBillTextBox.Name = "TransitBillTextBox";
            this.TransitBillTextBox.Size = new System.Drawing.Size(259, 20);
            this.TransitBillTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Введите номер текущего транзитного счета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(667, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(не обязательно, но ели ввести - исправляет баг Эльбы, при котором поступление на" +
    " транзитный счет считаются конвертацией) ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransitBillTextBox);
            this.Controls.Add(this.DoneLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DelimiterEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SkipFirstNRowsEdit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox SkipFirstNRowsEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DelimiterEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label DoneLabel;
        private System.Windows.Forms.TextBox TransitBillTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

