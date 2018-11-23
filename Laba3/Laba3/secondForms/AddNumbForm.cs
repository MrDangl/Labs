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
            if (drobCheckBox.Checked == true)
            {
                DrobNumber x = new DrobNumber();
                x.Numerator = Convert.ToDouble(maskedTextBox1.Text);
                x.Denominator = Convert.ToDouble(maskedTextBox2.Text);
                x.Transfer();
                MessageBox.Show("обьект создан его запись " + x.Count);
                Array.Resize(ref Main.Global.drb, Main.Global.drb.Length + 1);
                Main.Global.drb[Main.Global.drb.Length - 1] = x;
            }
            if (komplexCheckBox.Checked == true)
            {
                KomplexNumber x = new KomplexNumber();
                x.Exictedpart = Convert.ToDouble(maskedTextBox1.Text);
                x.Fakepart = Convert.ToDouble(maskedTextBox2.Text);
                x.Transfer();
                MessageBox.Show("обьект создан его запись " + x.Count);
                Array.Resize(ref Main.Global.kmp, Main.Global.kmp.Length + 1);
                Main.Global.kmp[Main.Global.kmp.Length - 1] = x;
            }
        }

        private void drobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            komplexCheckBox.Checked = false;
            komplexlabel1.Visible = false;
            komplexlabel2.Visible = false;
            droblabel1.Visible = true;
            droblabel2.Visible = true;
            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = true;
            addButton.Visible = true;
        }

        private void komplexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drobCheckBox.Checked = false;
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
