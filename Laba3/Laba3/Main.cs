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
            
            public static  List<Number> nmb = new List<Number>(); 
            
            
        }
        
        
        public Main()
        {
            InitializeComponent();
        }

        private void writeTolStrip_Click(object sender, EventArgs e)
        {  
            string text = "";
            StreamWriter sw = new StreamWriter("papka.txt");
            for (int i = 0; i < Global.nmb.Count; i++)
            {
                if (Global.nmb[i] is KomplexNumber)
                { KomplexNumber a = new KomplexNumber();
                    a = Global.nmb[i] as KomplexNumber;
                    text = "kmp " + a.Exictedpart +" "+ a.Fakepart ; 
                }
                if (Global.nmb[i] is DrobNumber)
                {
                    DrobNumber a = new DrobNumber();
                    a = Global.nmb[i] as DrobNumber;
                    text = "drb " + a.Numerator+" "+ a.Numerator;
                }
                sw.WriteLine(text);
                
            }
            sw.Close();
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            Global.nmb.Clear();
            string[] text;
            string line = "";
            StreamReader sr = new StreamReader("papka.txt");
            while ((line = sr.ReadLine()) != null)
            {
                text = line.Split(' ');
                if (text[0] == "kmp")
                {
                    KomplexNumber a = new KomplexNumber();
                    a.Exictedpart = Convert.ToDouble(text[1]);
                    a.Fakepart = Convert.ToDouble(text[2]);
                    a.Transfer();
                    Global.nmb.Add(a);
                }
                if (text[0] == "drb")
                {
                    DrobNumber a = new DrobNumber();
                    a.Numerator = Convert.ToDouble(text[1]);
                    a.Denominator = Convert.ToDouble(text[2]);
                    a.Transfer();
                    Global.nmb.Add(a);
                }

            }
            sr.Close();
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
        public virtual string AsText() { return ""; }

        protected double nmbvalue;
        public double GetValue
        { get { return nmbvalue; } }
    }

    public class KomplexNumber : Number
    {
        double exictedpart;
        double fakepart;
        public override string  AsText()
        {
            return "" + " Тип : Комплексное число " + Exictedpart + " + " + Fakepart + " i Приблизительно равен " + GetValue;
        }
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
        public override string AsText()
        {
            return "" + " Тип : дробь " + numerator + " / " + denominator + " и приблизительно равен " + GetValue;
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
