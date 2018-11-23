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

namespace Laba3
{
    public partial class Main : Form
    {
        public class Global
        {
            public static KomplexNumber[] kmp = new KomplexNumber[0];
            public static DrobNumber[] drb = new DrobNumber[0];
            
            
        }
        
        
        public Main()
        {
            InitializeComponent();
        }

        private void writeTolStrip_Click(object sender, EventArgs e)
        {
            string text = "";
            StreamWriter sw = new StreamWriter("papka.txt");
            for(int i=0; i<Global.drb.Length;i++)
            {
                text = "drb " + Global.drb[i].Count + " " + Global.drb[i].Numerator + " " + Global.drb[i].Denominator + " " + Global.drb[i].GetValue;
                sw.WriteLine(text);
                
            }
            for (int i = 0; i < Global.kmp.Length; i++)
            {
                text = "kmp " + Global.kmp[i].Count + " " + Global.kmp[i].Exictedpart + " " + Global.kmp[i].Fakepart + " " + Global.kmp[i].GetValue;
                sw.WriteLine(text);
                
            }
            sw.Close();
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            Number.count = 0;
            Global.drb = new DrobNumber[0];
            Global.kmp = new KomplexNumber[0];
            string[] text;
            string line = "";
            StreamReader sr = new StreamReader("papka.txt");
            while ((line = sr.ReadLine()) != null)
            {
                text = line.Split(' ');
                if (text[0] == "drb")
                {
                    DrobNumber x = new DrobNumber();
                    x.Numerator = Convert.ToInt16(text[2]);
                    x.Denominator = Convert.ToInt16(text[3]);
                    x.Count = Convert.ToInt16(text[1]);
                    x.Transfer();
                    Array.Resize(ref Main.Global.drb, Main.Global.drb.Length + 1);
                    Main.Global.drb[Main.Global.drb.Length - 1] = x;
                }
                ;
                if (text[0] == "kmp")
                {
                    KomplexNumber x = new KomplexNumber();
                    x.Exictedpart = Convert.ToInt16(text[2]);
                    x.Fakepart = Convert.ToInt16(text[3]);
                    x.Count = Convert.ToInt16(text[1]);
                    x.Transfer();
                    Array.Resize(ref Main.Global.kmp, Main.Global.kmp.Length + 1);
                    Main.Global.kmp[Main.Global.kmp.Length - 1] = x;
                }
                ;
            }
        }

        private void addNumb_Click(object sender, EventArgs e)
        {
            AddNumbForm form = new AddNumbForm();
            form.Show();
        }

        private void changeNumb_Click(object sender, EventArgs e)
        {
            ChangeNumbForm form = new ChangeNumbForm();
            form.Show();
        }

        private void showList_Click(object sender, EventArgs e)
        {
            ShowListForm form = new ShowListForm();
            form.Show();
        }

        private void findToolStrip_Click(object sender, EventArgs e)
        {
            FindNmbList form = new FindNmbList();
            form.Show();
        }
    }

    public class Number
    {
        public static int count = 0;
        public int Items
        {
            get { return count; }
        }
        private int id;
        public int Count
        {
            get { return id; }
            set { id = value; }
        }
        public Number()
        {
            count++;
            id = count;
        }
        protected double nmbvalue;
        public double GetValue
        { get { return nmbvalue; } }
    }

    public class KomplexNumber : Number
    {
        double exictedpart;
        double fakepart;
        public double Transfer()
        {
            nmbvalue = Math.Sqrt(Math.Pow(exictedpart, 2) + Math.Pow(fakepart, 2));
            nmbvalue = Math.Round(nmbvalue, 4);
            return nmbvalue;
        }
        public double Fakepart
        {
            get { return fakepart; }
            set { fakepart = value; }
        }
        public double Exictedpart
        {
            get { return exictedpart; }
            set { exictedpart = value; }
        }
    }

    public class DrobNumber : Number
    {
        double numerator, denominator;
        public double Transfer()
        {
            nmbvalue = numerator / denominator;
            nmbvalue = Math.Round(nmbvalue, 4);
            return nmbvalue;
        }
        public double Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public double Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
    }

}
