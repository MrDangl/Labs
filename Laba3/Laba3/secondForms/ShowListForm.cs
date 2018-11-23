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
    public partial class ShowListForm : Form
    {
        public ShowListForm()
        {
            InitializeComponent();
            int a = 0;
            for (int i = 0; i < Main.Global.drb.Length; i++)
            {
                for (int j = 0; j < Main.Global.kmp.Length; j++)
                {
                    
                    if (a == Main.Global.drb[i].Count -1 )
                    {
                        listBox1.Items.Add(Main.Global.drb[i].Count + " Тип : Дробь " + Main.Global.drb[i].Numerator + "/" + Main.Global.drb[i].Denominator + " Приблизительно равен " + Main.Global.drb[i].GetValue);
                    }
                    else
                        listBox1.Items.Add(Main.Global.kmp[j].Count + " Тип : Комплексное число " + Main.Global.kmp[j].Exictedpart + " + " + Main.Global.kmp[j].Fakepart + "i Приблизительно равен " + Main.Global.drb[j].GetValue);

                    
                }
            }
            
        }
        
    }
}
