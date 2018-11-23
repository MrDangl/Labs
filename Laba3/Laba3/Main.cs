using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
    public partial class Main : Form
    {
        public class Global
        {
            public static KomplexNumber[] kmp = new KomplexNumber[0];
            public static DrobNumber[] drb = new DrobNumber[0];
            
        }
        public class Number
        {
            public static int count = 0;
            public Number()
            { count++; }
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
                nmbvalue = numerator/denominator;
                nmbvalue = Math.Round(nmbvalue, 4);
                return nmbvalue;
            }
            public double Numerator
            {
                get { return numerator; }
                set { numerator = value;}
            }
            public double Denominator
            {
                get { return denominator; }
                set { denominator = value; }
            }
        }
        
        public Main()
        {
            InitializeComponent();
        }

        private void writeTolStrip_Click(object sender, EventArgs e)
        {

        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {

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
}
