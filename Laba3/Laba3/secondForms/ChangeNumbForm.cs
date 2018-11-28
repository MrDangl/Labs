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
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            
            droblabel1.Visible = false;
            droblabel2.Visible = false;
            komplexlabel1.Visible = false;
            komplexlabel2.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            addButton.Visible = false;
            i = Convert.ToInt16(maskedTextBox3.Text) - 1;
            if (i > 0 && i < Main.Global.nmb.Count)
            {
               
                if (i > 0 && Main.Global.nmb[i] is KomplexNumber)
                { 
                    KomplexNumber a = new KomplexNumber();
                    a = Main.Global.nmb[i] as KomplexNumber;
                    komplexlabel1.Visible = true;
                    komplexlabel2.Visible = true;
                    maskedTextBox1.Visible = true;
                    maskedTextBox2.Visible = true;
                    addButton.Visible = true;
                    text = ""+ a.Exictedpart;
                    maskedTextBox1.Text = Convert.ToString(text);
                    text = ""+ a.Fakepart;
                    maskedTextBox2.Text = Convert.ToString(text);

                }
                if (Main.Global.nmb[i] is DrobNumber)
                {
                    DrobNumber a = new DrobNumber();
                    a = Main.Global.nmb[i] as DrobNumber;
                    droblabel1.Visible = true;
                    droblabel2.Visible = true;
                    maskedTextBox1.Visible = true;
                    maskedTextBox2.Visible = true;
                    addButton.Visible = true;
                    maskedTextBox1.Text = Convert.ToString(a.Numerator);
                    maskedTextBox2.Text = Convert.ToString(a.Denominator);
                }

            }
            else MessageBox.Show("Данной записи нет в памяти");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (i > 0 && i < Main.Global.nmb.Count)
                {
                    if (Main.Global.nmb[i] is KomplexNumber)
                    {
                        KomplexNumber a = Main.Global.nmb[i] as KomplexNumber;
                        a.Exictedpart = Convert.ToDouble(maskedTextBox1.Text);
                        a.Fakepart = Convert.ToDouble(maskedTextBox2.Text);
                        a.Transfer();
                    }
                    if (Main.Global.nmb[i] is DrobNumber)
                    {
                        DrobNumber a = Main.Global.nmb[i] as DrobNumber;
                        a.Numerator = Convert.ToDouble(maskedTextBox1.Text);
                        a.Denominator = Convert.ToDouble(maskedTextBox2.Text);
                        a.Transfer();
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Ошбика, заполните таблицу правильно"); }
        }
    }
}
