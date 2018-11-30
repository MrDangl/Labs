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
        public static bool Find(MaskedTextBox a)
        {
            int i = Convert.ToInt16(a.Text);
            if (i > -1 && i < Main.Global.nmb.Count)
            { return true; }
            else { return false; }
        }
        public FindNmbList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Find(maskedTextBox3) ==true)
            {
                MessageBox.Show(Main.Global.nmb[Convert.ToInt16(maskedTextBox3.Text)].AsText());
            }
            
        }
    }
}
