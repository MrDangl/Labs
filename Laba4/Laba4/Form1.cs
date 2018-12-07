using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using ClassLibrary1;

namespace Laba4
{
    public partial class Form1 : Form
    {
        //define variables
        int numberofzapros = 0;
        int[] el = new int[10];
        Random ran = new Random();
        string[] text = { "Бояться надо не смерти, а пустой жизни ", "Там, где кончается терпение, начинается выносливость", "Отличный способ проверить человека - это довериться ему", "14579643", "Человек ценен, когда его слова совпадают с его действиями" };
        List<Drugs> drugs = new List<Drugs>();
        List<Books> books = new List<Books>();
        List<Readers> readers = new List<Readers>();
        public Form1()
        {

            InitializeComponent();
            for (int i = 0; i < el.Length; i++)
            {
                el[i] = 100 - ran.Next(200);
            }
            //define drugslist
            {
                drugs.Add(new Drugs("Парацетомол","МедГруп",4,15,5));
                drugs.Add(new Drugs("АЦЦ", "D-Comp", 10, 26, 40));
                drugs.Add(new Drugs("Ревит", "Медгруп", 2, 24, 10));
                drugs.Add(new Drugs("Ношпа","РосМед",8,10,100));
                drugs.Add(new Drugs("Форингосепт", "ABC",11,45,10));
            }
            //define bookslist
            {
                books.Add(new Books(1, "Дон Кихот", "Мигель де Сервантес", "1615", "Художественное", 615));
                books.Add(new Books(2, "С# для чайников", "Microsoft", "2014", "Учебное", 520));
                books.Add(new Books(3, "Биология для 9 класса", "Понамарева", "2017", "Учебное", 120));
                books.Add(new Books(4, "Остров Сокровищь", "N/A", "1880", "Художественное", 125));
            }
            //define person
            {
                readers.Add(new Readers("Глеб Данилов", "Бульвар рябикова 5", 614243, "1,2"));
                readers.Add(new Readers("Денис Шелковников", "Улан Батора 13", 75014, "4"));
                readers.Add(new Readers("Иван Климачев", "Ангарск Ленина 5", 213562, "2,4"));
                readers.Add(new Readers("Валера Глазков", "Степана Разина 12", 231445, "3"));

            }
        }

        public bool IfNumber(string t)
        {
            
            int n;
            if (int.TryParse(t, out n) == true)
                return true;
            else return false;
        }
        public void Clear()
        {

            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.ResetText();
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
            middleButton.Text = "Посчитать";
            for (int i = 0; i < drugs.Count; i++)
            {
                listBox1.Items.Add(drugs[i].AsText());
            }

        }
        public void Zapros4_Show()
        {
            numberofzapros = 4;
            listBox1.Visible = true;
            labelzapros4.Visible = true;
            labelzapros4.Location = labelzapros1.Location;
            leftButton.Visible = true;
            rightButton.Visible = true;
            listBox1.Items.Add("Книги в библиотеке");
            for (int i = 0; i < books.Count; i++)
            {
                listBox1.Items.Add(books[i].AsText());
            }
            listBox1.Items.Add("Посетители библиотеки");
            for (int i = 0; i < books.Count; i++)
            {
                listBox1.Items.Add(readers[i].AsText());
            }
            leftButton.Text = "Группа";
            rightButton.Text = "Сумма";
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
            listBox1.DataSource = text;
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
            int k;
            string line = "";
            string[] names = new string[readers.Count];
            //var idqueristring = from c in readers where c.IdBooks;
            var bookid = from c in books select c.ID;
            

        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            
            if (numberofzapros == 1)
            {
                int add = 1;
                var querystring = el.Where(c => c % 2 == 0);
                foreach (int i in querystring)
                {
                    add = add*i;
                }
                MessageBox.Show("Произведение четных элементов равно: " + add);
            }
            if (numberofzapros == 2)
            {
                string line = "";
               
                var querytring = text.Where(c => IfNumber(c) == true  );
                foreach (string i in querytring)
                {
                    line += " " + i;
                }
                MessageBox.Show("Строка(Строки) " + line + " являются изображением числа");

            }
            if (numberofzapros ==3)
            {
                int n;
                if (int.TryParse(textBox1.Text,out n)==true)
                {
                    n = Convert.ToInt16(textBox1.Text);
                    var querytring = drugs.Where(c => c.ID == n);
                    foreach (Drugs t in querytring)
                        MessageBox.Show("Цена проданных лекарств равно " + t.NumbOfPack * t.Cost);
                }
                else
                {
                    string line = textBox1.Text;
                    var querytring = drugs.Where(c => c.Name == line);
                    foreach (Drugs t in querytring)
                        MessageBox.Show("Цена проданных лекарств равно " + t.NumbOfPack * t.Cost);
                }
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {

        }
    }

}
    


