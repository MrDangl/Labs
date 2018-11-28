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
                
                    sw.WriteLine(Global.nmb[i]);
                
            }
            sw.Close();
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            Number.count = 0;
            Global.nmb.Clear();
            string[] text;
            object t;
            string line = "";
            StreamReader sr = new StreamReader("papka.txt");
            while ((line = sr.ReadLine()) != null)
            {
                
                 DrobNumber d = new DrobNumber();
                
                
                
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
        protected int id;
        public int Count
        {
            get { return id; }
            set { id = value; }
        }
        public virtual string AsText() { return ""; }
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
        public override string  AsText()
        {
            return "" + id + " Тип : Комплексное число " + Exictedpart + " + " + Fakepart + " i Приблизительно равен " + GetValue;
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
            return "" + id + " Тип : дробь " + numerator + " / " + denominator + " и приблизительно равен " + GetValue;
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
