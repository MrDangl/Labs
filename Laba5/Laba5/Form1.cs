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
        Regex Test = new Regex(@"http://+[A-Za-z]+\.+[A-Za-z]*\.*[A-Za-z]*");
        string result;

        private void form1_SizeChange(object sender,EventArgs e)
        {
            tabControl1.Height = Height - 100;
            tabControl1.Width = Width - 50;
            richTextBox1.Height = tabControl1.Height - 150;
            richTextBox2.Height = tabControl1.Height - 150;
            richTextBox3.Height = tabControl1.Height - 150;
            richTextBox4.Height = tabControl1.Height - 150;

            richTextBox1.Width = tabControl1.Width / 2 - 50;
            richTextBox2.Width = tabControl1.Width / 2 - 50;
            richTextBox3.Width = tabControl1.Width / 2 - 50;
            richTextBox4.Width = tabControl1.Width / 2 - 50;
            
            Point p = new Point(richTextBox1.Location.X + richTextBox1.Width + 30, 50);
            richTextBox2.Location = p;
            Point p1 = new Point(richTextBox3.Location.X + richTextBox3.Width + 30, 50);
            richTextBox4.Location = p1;
            
            label1.Location = new Point(richTextBox1.Location.X + (richTextBox1.Width / 2) - 60, 30);
            label2.Location = new Point(richTextBox2.Location.X + richTextBox2.Width / 2 - 70, 30);
            label4.Location = new Point(richTextBox3.Location.X + richTextBox3.Width / 2 - 70, 30);
            label5.Location = new Point(richTextBox4.Location.X + richTextBox4.Width / 2 - 70, 30);
            
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
            richTextBox2.Text = Test.Replace(richTextBox1.Text, " ...");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Regex test = new Regex(textBox1.Text);
                
                richTextBox3.Text = test.Matches(richTextBox1.Text).ToString();
                richTextBox4.Text = test.Replace(richTextBox1.Text, "Replace");
            }
            catch(Exception)
            {
                
            }
        }
    }
}
