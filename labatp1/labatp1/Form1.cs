using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labatp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        
        public static void GridChange(DataGridView a)
        {
            //DataGridViewElementStates flag = new DataGridViewElementStates;
            a.AutoResizeColumns();
            a.AutoResizeRows();
            //int wight = a.Columns.GetColumnsWidth(DataGridViewElementStates.ResizableSet);
            a.Size = new Size(30 * Global.matrix_a.columns ,20 * Global.matrix_a.rows);
        }

        class Global
        {
            public static Matrix matrix_a, matrix_b, matrix_c;
            
        }
        
        struct Matrix
        {
            public int rows, columns;
            public int[,] matr;
            
            public int[,] Addition(Matrix a,Matrix b)
            {
                for(int i=0; i<rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        a.matr[i, j] += b.matr[i, j];
                    }
                }
                return a.matr;
            }
            public int[,] Multiplication(Matrix a, int b)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        a.matr[i, j] *= b;
                    }
                }
                return a.matr;
            }
            public int findNumb(Matrix a, int b)
            {
                int summ=0;
                for (int i = 0; i < columns; i++)
                {
                    summ += a.matr[b, i];
                }
                return summ;
            }
        }
        private void creatMatrButton_Click(object sender, EventArgs e)
        {
            matrixDataGrid1.Columns.Clear();
            matrixDataGrid1.Rows.Clear();
            Global.matrix_a.rows = Convert.ToInt16(rowsMaskTB.Text);
            Global.matrix_a.columns = Convert.ToInt16(columnsMaskTB.Text);
            Global.matrix_b.rows = Convert.ToInt16(rowsMaskTB.Text);
            Global.matrix_b.columns = Convert.ToInt16(columnsMaskTB.Text);
            matrixDataGrid1.RowCount  = Global.matrix_a.rows;
            matrixDataGrid1.ColumnCount = Global.matrix_a.columns;
            matrixDataGrid2.RowCount = Global.matrix_a.rows;
            matrixDataGrid2.ColumnCount = Global.matrix_a.columns;
            GridChange(matrixDataGrid1);
            GridChange(matrixDataGrid2);
            GridChange(matrixDataGrid3);
            if (matrixDataGrid1.Location.X + matrixDataGrid1.Size.Width > Width)
            {
                {
                    Point x = new Point(10, matrixDataGrid2.Location.Y + matrixDataGrid1.Size.Height + 50);
                    matrixDataGrid2.Location = x;
                    x.Offset(50, -25);
                    label3.Location = x;
                    if (matrixDataGrid1.Location.X + matrixDataGrid1.Size.Width > Width)
                    {
                        Width = matrixDataGrid1.Location.X + matrixDataGrid1.Size.Width + 50;

                    }
                }
            }
            else if (matrixDataGrid1.Location.X + matrixDataGrid1.Size.Width > matrixDataGrid2.Location.X)
            {
                Point x = new Point(matrixDataGrid1.Location.X + matrixDataGrid1.Size.Width+50,matrixDataGrid2.Location.Y);
                matrixDataGrid2.Location = x;
                x.Offset( 50, -25);
                label3.Location = x;
                if (matrixDataGrid2.Location.X + matrixDataGrid2.Size.Width > Width)
                {
                    Width = matrixDataGrid2.Location.X + matrixDataGrid2.Size.Width+50;
                    
                }

            }
            if (matrixDataGrid2.Location.X + matrixDataGrid2.Size.Width > Width +50)
            {
                Point y = new Point((matrixDataGrid1.Location.X + matrixDataGrid1.Size.Width + 50)/2, matrixDataGrid2.Location.Y + matrixDataGrid1.Size.Height +50 );
                matrixDataGrid3.Location = y;
                y.Offset(50, -25);
                label6.Location = y;
                if (matrixDataGrid3.Location.Y + matrixDataGrid3.Size.Height > Height)
                {
                    Height = matrixDataGrid3.Location.Y + matrixDataGrid3.Size.Height + 50;
                }

            }
            if (matrixDataGrid2.Location.Y != matrixDataGrid1.Location.Y)
            {
                {
                    Point x = new Point(20, matrixDataGrid2.Location.Y + matrixDataGrid3.Size.Height + 50);
                    matrixDataGrid3.Location = x;
                    x.Offset(50, -25);
                    label6.Location = x;
                   
                }
            }
            
        }

        private void randomMatrButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Global.matrix_a.matr = new int[Global.matrix_a.rows, Global.matrix_a.columns];
            Global.matrix_b.matr = new int[Global.matrix_b.rows, Global.matrix_b.columns];
            if (Convert.ToInt16(randMatrButton.Text) == 1 || Convert.ToInt16(randMatrButton.Text) == 2)
            {
                if (Convert.ToInt16(randMatrButton.Text) == 1)
                {

                    for (int i = 0; i < Global.matrix_a.rows; i++)
                    {
                        for (int j = 0; j < Global.matrix_a.columns; j++)
                        {
                            Global.matrix_a.matr[i, j] = r.Next(200) - 100;
                            matrixDataGrid1[j, i].Value = Global.matrix_a.matr[i, j];
                        }
                    }
                }
                if (Convert.ToInt16(randMatrButton.Text) == 2)
                {
                    for (int i = 0; i < Global.matrix_a.rows; i++)
                    {
                        for (int j = 0; j < Global.matrix_a.columns; j++)
                        {
                            Global.matrix_a.matr[i, j] = r.Next(200) - 100;
                            matrixDataGrid1[j, i].Value = Global.matrix_a.matr[i, j];
                        }
                    }
                    for (int i = 0; i < Global.matrix_b.rows; i++)
                    {
                        for (int j = 0; j < Global.matrix_b.columns; j++)
                        {
                            Global.matrix_b.matr[i, j] = r.Next(200) - 100;
                            matrixDataGrid2[j, i].Value = Global.matrix_b.matr[i, j];
                        }
                    }
                }
            }
            else MessageBox.Show("Введите значение равное 1 или 2", "Ошибка",MessageBoxButtons.OK);
            GridChange(matrixDataGrid1);
        }

        private void multMatrButton_Click(object sender, EventArgs e)
        {
            Global.matrix_c = Global.matrix_a;
            Global.matrix_c.Multiplication(Global.matrix_a, Convert.ToInt16(multMaskTB.Text));
            for (int i = 0; i < Global.matrix_b.rows; i++)
            {
                for (int j = 0; j < Global.matrix_b.columns; j++)
                {
                    matrixDataGrid2[i, j].Value = Global.matrix_c.matr[i, j];
                }
            }

        }

        private void addMatrButton_Click(object sender, EventArgs e)
        {
            Global.matrix_c = Global.matrix_a;
            Global.matrix_c.Addition(Global.matrix_a, Global.matrix_b);
            matrixDataGrid3.RowCount = Global.matrix_c.rows;
            matrixDataGrid3.ColumnCount = Global.matrix_c.columns;
            matrixDataGrid3.Visible = true;       
            for (int i = 0; i < Global.matrix_b.rows; i++)
            {
                for (int j = 0; j < Global.matrix_b.columns; j++)
                {
                    matrixDataGrid3[j, i].Value = Global.matrix_c.matr[i, j];
                }
            }

        }

        private void findSumButton_Click(object sender, EventArgs e)
        {
            int k;
            if (Convert.ToInt16(findColumnMaskTB.Text) < matrixDataGrid1.RowCount)
            {
                k = Global.matrix_a.findNumb (Global.matrix_a, Convert.ToInt16(findColumnMaskTB.Text));
                answerTB.Text = "" + k;
            }
            answerTB.Visible = true;
        }
    }
}
