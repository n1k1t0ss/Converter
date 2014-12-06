using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvTo1C.Contracts;

namespace CsvTo1C.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var settings = new Settings1();
            SkipFirstNRowsEdit.Text = settings.SkipFirstNRows.ToString();

            DelimiterEdit.Text = settings.Delimiter;
            DoneLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var main = new Main();
                main.ConvertCsvTo1C(textBox1.Text, int.Parse(SkipFirstNRowsEdit.Text), DelimiterEdit.Text);
                textBox1.Text = string.Empty;
                DoneLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// Process open file dialog box results
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                DoneLabel.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://msdn.microsoft.com/ru-ru/library/h21280bw.aspx");
        }
    }
}
