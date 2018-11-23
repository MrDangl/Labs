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
    public partial class ChangeNumbForm : Form
    {
        public ChangeNumbForm()
        {
            InitializeComponent();
        }
        int id;
        string type;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(maskedTextBox3.Text) >= Number.count)
            {
                for (int i = 0; i < Number.count; i++)
                {
                    for (int j = 0; j < Main.Global.drb.Length; j++)
                    {
                        if (Main.Global.drb[j].Count == i)
                        {

                            komplexlabel1.Visible = false;
                            komplexlabel2.Visible = false;
                            droblabel1.Visible = true;
                            droblabel2.Visible = true;
                            maskedTextBox1.Visible = true;
                            maskedTextBox1.Text = Main.Global.drb[j].Numerator.ToString();
                            maskedTextBox2.Visible = true;
                            maskedTextBox2.Text = Main.Global.drb[j].Denominator.ToString();
                            button1.Visible = true;
                            id = j;
                            type = "drb";
                        }
                    }
                    for (int k = 0; k < Main.Global.kmp.Length; k++)
                    {
                        if (i == Main.Global.kmp[k].Count)
                        {
                            komplexlabel1.Visible = true;
                            komplexlabel2.Visible = true;
                            droblabel1.Visible = false;
                            droblabel2.Visible = false;
                            maskedTextBox1.Visible = true;
                            maskedTextBox1.Text = Main.Global.kmp[k].Exictedpart.ToString();
                            maskedTextBox2.Visible = true;
                            maskedTextBox2.Text = Main.Global.kmp[k].Fakepart.ToString();
                            button1.Visible = true;
                            id = k;
                            type = "kmp";
                        }
                    }
                }
            }
            else MessageBox.Show("Данной записи нет в памяти");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (type == "kmp")
            {
                Main.Global.kmp[id].Exictedpart = Convert.ToDouble(maskedTextBox1.Text);
                Main.Global.kmp[id].Fakepart = Convert.ToDouble(maskedTextBox2.Text);
                Main.Global.kmp[id].Transfer();
            }
            if (type == "drb")
            {
                Main.Global.drb[id].Numerator = Convert.ToDouble(maskedTextBox1.Text);
                Main.Global.drb[id].Denominator = Convert.ToDouble(maskedTextBox2.Text);
                Main.Global.drb[id].Transfer();
            }
        }
    }
}
