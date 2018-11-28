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
            for (int i = 0; i < Main.Global.nmb.Count; i++)
            {
                if (Convert.ToInt16(maskedTextBox3.Text) == Main.Global.nmb[i].Count)
                    MessageBox.Show(Main.Global.nmb[i].AsText());
            }
        }
    }
}
