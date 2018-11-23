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
    public partial class FindNmbList : Form
    {
        public FindNmbList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Main.Number.count; i++)
            {
                for (int j = 0; j < Main.Global.drb.Length; j++)
                {
                    if (Main.Global.drb[j].Count == i)
                    {
                        MessageBox.Show(Main.Global.drb[j].Count + " Тип : Дробь " + Main.Global.drb[j].Numerator + "/" + Main.Global.drb[j].Denominator + " Приблизительно равен " + Main.Global.drb[j].GetValue);
                    }
                }
                for (int k = 0; k < Main.Global.kmp.Length; k++)
                {
                    if (i == Main.Global.kmp[k].Count)
                    {
                        MessageBox.Show(Main.Global.kmp[k].Count + " Тип : Комплексное число " + Main.Global.kmp[k].Exictedpart + " + " + Main.Global.kmp[k].Fakepart + "i Приблизительно равен " + Main.Global.kmp[k].GetValue);
                    }
                }
            }

        }
    }
}
