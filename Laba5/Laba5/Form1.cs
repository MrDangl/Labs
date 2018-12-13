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
            listBox1.Items.Add("keklol@yandex.ru");
        }
        Regex Test = new Regex(@"[A-Za-z]+[\.A-Za-z0-9_-]*[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]+");
        string result;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "|.txt";
            a.ShowDialog();
            try
            {
                StreamReader sr = new StreamReader(a.FileName);
                text = sr.ReadToEnd();
            }
            catch (Exception) { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.Filter = "|.txt";
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
            result = Test.Replace(listBox1.Items[0].ToString(), listBox1.Items[0].ToString() +"1");
            listBox2.Items.Add(result);
        }
    }
}
