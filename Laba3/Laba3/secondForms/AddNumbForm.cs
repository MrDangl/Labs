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
    public partial class AddNumbForm : Form
    {
        public AddNumbForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (drobRadioButton.Checked == true)
                {
                    DrobNumber x = new DrobNumber();
                    x.Numerator = Convert.ToDouble(maskedTextBox1.Text);
                    x.Denominator = Convert.ToDouble(maskedTextBox2.Text);
                    x.Transfer();
                    Main.Global.nmb.Add(x);
                    MessageBox.Show("обьект создан его запись " + Main.Global.nmb.Count+1);

                }
                if (komplexRadioButton.Checked == true)
                {
                    KomplexNumber x = new KomplexNumber();
                    x.Exictedpart = Convert.ToDouble(maskedTextBox1.Text);
                    x.Fakepart = Convert.ToDouble(maskedTextBox2.Text);
                    x.Transfer();
                    MessageBox.Show("обьект создан его запись " + Main.Global.nmb.Count+1);
                    Main.Global.nmb.Add(x);
                }
            }
            catch (Exception) { MessageBox.Show("Ошибка! Проверьте правильность формы"); }
        }
        
        private void drobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            komplexlabel1.Visible = false;
            komplexlabel2.Visible = false;
            droblabel1.Visible = true;
            droblabel2.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = true;
            addButton.Visible = true;

        }

        private void komplexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            droblabel1.Visible = false;
            droblabel2.Visible = false;
            komplexlabel1.Visible = true;
            komplexlabel2.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = true;
            addButton.Visible = true;
        }
    }
}
