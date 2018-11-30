using System;
using System.Windows.Forms;
using System.Linq;
using ClassLibrary1;

namespace Laba4
{
    public partial class Form1 : Form
    {
        int numberofzapros = 0;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < el.Length; i++)
            {
                el[i] = 100 - ran.Next(200);
            }
        }
        int[] el = new int[20];
        Random ran = new Random();

    public void Clear()
        {
            listBox1.Text = "";
            label1.Visible = false;
            leftButton.Visible = false;
            middleButton.Visible = false;
            rightButton.Visible = false;
            listBox1.Visible = false;
            textBox1.Visible = false;
            labelzapros1.Visible = false;
            labelzapros2.Visible = false;
            labelzapros3.Visible = false;
            labelzapros4.Visible = false;
        }
        public void Zapros1_Show()
        {
            numberofzapros = 1;
            labelzapros1.Visible = true;
            listBox1.Visible = true;
            middleButton.Visible = true;
            middleButton.Text = "Найти";         
            
        }
        public void Zapros2_Show()
        {
            numberofzapros = 2;
            listBox1.Visible = true;
            labelzapros2.Visible = true;
            labelzapros2.Location = labelzapros1.Location;
            middleButton.Visible = true;
            middleButton.Text = "Найти";
        }
        public void Zapros3_Show()
        {
            numberofzapros = 3;
            listBox1.Visible = true;
            labelzapros3.Visible = true;
            labelzapros3.Location = labelzapros1.Location;
            middleButton.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            middleButton.Text = "Выполнить";
            
        }
        public void Zapros4_Show()
        {
            numberofzapros = 4;
            listBox1.Visible = true;
            labelzapros4.Visible = true;
            labelzapros4.Location = labelzapros1.Location;
            leftButton.Visible = true;
            middleButton.Visible = true;
            rightButton.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clear();
            Zapros1_Show();


            listBox1.DataSource = el;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clear();
            Zapros2_Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Clear();
            Zapros3_Show();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Clear();
            Zapros4_Show();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {

        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            
            if (numberofzapros == 1)
            {
                int add = 1;
                var querystring = el.Where(c => c % 2 == c / 2);
                foreach (int i in querystring)
                {
                    add *= i;
                }
                MessageBox.Show("Произведение четных элементов равно: " + add);
            }
          
        }

        private void rightButton_Click(object sender, EventArgs e)
        {

        }
    }

}
    


