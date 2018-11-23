﻿using System;
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
                Main.DrobNumber x = new Main.DrobNumber();
                x.Numerator = Convert.ToDouble(maskedTextBox1.Text);
                x.Denominator = Convert.ToDouble(maskedTextBox2.Text);
                x.Transfer();
                MessageBox.Show("обьект создан его запись" + Main.Number.count);
            }
            if (komplexCheckBox.Checked == true)
            {
                Main.KomplexNumber x = new Main.KomplexNumber();
                x.Exictedpart = Convert.ToDouble(maskedTextBox1.Text);
                x.Fakepart = Convert.ToDouble(maskedTextBox2.Text);
                MessageBox.Show("обьект создан его запись" + Main.Number.count);
                Array.Resize(ref Main.Global.drb, Main.Global.drb.Length + 1);
                Main.Global
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
