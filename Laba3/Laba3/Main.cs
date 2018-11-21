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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void writeTolStrip_Click(object sender, EventArgs e)
        {

        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void addNumb_Click(object sender, EventArgs e)
        {
            AddNumbForm form = new AddNumbForm();
            form.Show();
        }

        private void changeNumb_Click(object sender, EventArgs e)
        {
            ChangeNumbForm form = new ChangeNumbForm();
            form.Show();
        }

        private void showList_Click(object sender, EventArgs e)
        {
            ShowListForm form = new ShowListForm();
            form.Show();
        }

        private void findToolStrip_Click(object sender, EventArgs e)
        {
            FindNmbList form = new FindNmbList();
            form.Show
        }
    }
}
