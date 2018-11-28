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
            for (int i = 0; i < Main.Global.nmb.Count; i++)
            {
                listBox1.Items.Add(i+1 +" "+Main.Global.nmb[i].AsText());
            }

        }
            
    }
        
}

