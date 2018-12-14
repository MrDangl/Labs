using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Laba5
{
    public partial class Form1 : Form
    {
        
        string text;
        public Form1()
        {
            InitializeComponent();
            Match a;
            
        }
        Regex Test = new Regex(@"[A-Za-z]+\.+[A-Za-z]+\.+[A-Za-z]+");
        string result;

        private void form1_SizeChange(object sender,EventArgs e)
        {
            richTextBox1.Height = Height - 200;
            richTextBox2.Height = Height - 200;
            richTextBox1.Width = Width / 2 - 50;
            richTextBox2.Width = Width / 2 - 50;
            Point p = new Point(richTextBox1.Location.X + richTextBox1.Width + 30, 70);
            richTextBox2.Location = p;
            label1.Location = new Point(richTextBox1.Location.X + (richTextBox1.Width / 2) - 60, 45);
            label2.Location = new Point(richTextBox2.Location.X + richTextBox2.Width / 2 - 70, 45);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "(*.txt)|*.txt";
            a.ShowDialog();
            try
            {
                StreamReader sr = new StreamReader(a.FileName);
                richTextBox1.Text = sr.ReadToEnd();
            }
            catch (Exception) { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "*.txt";
            a.ShowDialog();
            try
            {
                StreamWriter sw = new StreamWriter(a.FileName);
                sw.WriteLine(text);
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Test.Replace(richTextBox1.Text, "...");
            if (textBox1.Text !="")
            {
                try
                {
                    Regex Test2 = new Regex(textBox1.Text);
                }
                catch (Exception) { }
                }
        }

        private void ZadanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7.	поиск: гиперссылки в коде HTML страницы; замена: приведение гиперссылок к относительному виду (./***/***).");
        }
    }
}
