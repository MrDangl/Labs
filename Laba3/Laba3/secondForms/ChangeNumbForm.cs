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
                    
                }
            }
            else MessageBox.Show("Данной записи нет в памяти");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
