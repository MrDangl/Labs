namespace labatp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.matrixDataGrid1 = new System.Windows.Forms.DataGridView();
            this.matrixDataGrid2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.creatMatrButton = new System.Windows.Forms.Button();
            this.randomMatrButton = new System.Windows.Forms.Button();
            this.rowsMaskTB = new System.Windows.Forms.MaskedTextBox();
            this.randMatrButton = new System.Windows.Forms.MaskedTextBox();
            this.multMatrButton = new System.Windows.Forms.Button();
            this.addMatrButton = new System.Windows.Forms.Button();
            this.findSumButton = new System.Windows.Forms.Button();
            this.multMaskTB = new System.Windows.Forms.MaskedTextBox();
            this.findColumnMaskTB = new System.Windows.Forms.MaskedTextBox();
            this.answerTB = new System.Windows.Forms.TextBox();
            this.columnsMaskTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matrixDataGrid3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // matrixDataGrid1
            // 
            this.matrixDataGrid1.AllowUserToAddRows = false;
            this.matrixDataGrid1.AllowUserToDeleteRows = false;
            this.matrixDataGrid1.AllowUserToResizeColumns = false;
            this.matrixDataGrid1.AllowUserToResizeRows = false;
            this.matrixDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixDataGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.matrixDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixDataGrid1.ColumnHeadersVisible = false;
            this.matrixDataGrid1.EnableHeadersVisualStyles = false;
            this.matrixDataGrid1.Location = new System.Drawing.Point(10, 245);
            this.matrixDataGrid1.Name = "matrixDataGrid1";
            this.matrixDataGrid1.RowHeadersVisible = false;
            this.matrixDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixDataGrid1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrixDataGrid1.Size = new System.Drawing.Size(166, 151);
            this.matrixDataGrid1.TabIndex = 1;
            // 
            // matrixDataGrid2
            // 
            this.matrixDataGrid2.AllowUserToAddRows = false;
            this.matrixDataGrid2.AllowUserToDeleteRows = false;
            this.matrixDataGrid2.AllowUserToResizeColumns = false;
            this.matrixDataGrid2.AllowUserToResizeRows = false;
            this.matrixDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixDataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGrid2.ColumnHeadersVisible = false;
            this.matrixDataGrid2.EnableHeadersVisualStyles = false;
            this.matrixDataGrid2.Location = new System.Drawing.Point(211, 245);
            this.matrixDataGrid2.Name = "matrixDataGrid2";
            this.matrixDataGrid2.RowHeadersVisible = false;
            this.matrixDataGrid2.Size = new System.Drawing.Size(166, 151);
            this.matrixDataGrid2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Матрица А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Матрица B";
            // 
            // creatMatrButton
            // 
            this.creatMatrButton.Location = new System.Drawing.Point(133, 121);
            this.creatMatrButton.Name = "creatMatrButton";
            this.creatMatrButton.Size = new System.Drawing.Size(75, 23);
            this.creatMatrButton.TabIndex = 5;
            this.creatMatrButton.Text = "Создать";
            this.creatMatrButton.UseVisualStyleBackColor = true;
            this.creatMatrButton.Click += new System.EventHandler(this.creatMatrButton_Click);
            // 
            // randomMatrButton
            // 
            this.randomMatrButton.Location = new System.Drawing.Point(281, 121);
            this.randomMatrButton.Name = "randomMatrButton";
            this.randomMatrButton.Size = new System.Drawing.Size(75, 23);
            this.randomMatrButton.TabIndex = 6;
            this.randomMatrButton.Text = "Заполнить";
            this.randomMatrButton.UseVisualStyleBackColor = true;
            this.randomMatrButton.Click += new System.EventHandler(this.randomMatrButton_Click);
            // 
            // rowsMaskTB
            // 
            this.rowsMaskTB.Location = new System.Drawing.Point(34, 121);
            this.rowsMaskTB.Mask = "00";
            this.rowsMaskTB.Name = "rowsMaskTB";
            this.rowsMaskTB.ResetOnSpace = false;
            this.rowsMaskTB.Size = new System.Drawing.Size(21, 20);
            this.rowsMaskTB.TabIndex = 7;
            // 
            // randMatrButton
            // 
            this.randMatrButton.Location = new System.Drawing.Point(261, 121);
            this.randMatrButton.Mask = "0";
            this.randMatrButton.Name = "randMatrButton";
            this.randMatrButton.Size = new System.Drawing.Size(14, 20);
            this.randMatrButton.TabIndex = 8;
            // 
            // multMatrButton
            // 
            this.multMatrButton.Location = new System.Drawing.Point(472, 51);
            this.multMatrButton.Name = "multMatrButton";
            this.multMatrButton.Size = new System.Drawing.Size(75, 23);
            this.multMatrButton.TabIndex = 9;
            this.multMatrButton.Text = "Умножить\r\n ";
            this.multMatrButton.UseVisualStyleBackColor = true;
            this.multMatrButton.Click += new System.EventHandler(this.multMatrButton_Click);
            // 
            // addMatrButton
            // 
            this.addMatrButton.Location = new System.Drawing.Point(472, 107);
            this.addMatrButton.Name = "addMatrButton";
            this.addMatrButton.Size = new System.Drawing.Size(75, 23);
            this.addMatrButton.TabIndex = 10;
            this.addMatrButton.Text = "Сложить";
            this.addMatrButton.UseVisualStyleBackColor = true;
            this.addMatrButton.Click += new System.EventHandler(this.addMatrButton_Click);
            // 
            // findSumButton
            // 
            this.findSumButton.Location = new System.Drawing.Point(459, 152);
            this.findSumButton.Name = "findSumButton";
            this.findSumButton.Size = new System.Drawing.Size(88, 23);
            this.findSumButton.TabIndex = 11;
            this.findSumButton.Text = "Найти сумму";
            this.findSumButton.UseVisualStyleBackColor = true;
            this.findSumButton.Click += new System.EventHandler(this.findSumButton_Click);
            // 
            // multMaskTB
            // 
            this.multMaskTB.Location = new System.Drawing.Point(409, 51);
            this.multMaskTB.Mask = "0000";
            this.multMaskTB.Name = "multMaskTB";
            this.multMaskTB.ResetOnSpace = false;
            this.multMaskTB.Size = new System.Drawing.Size(31, 20);
            this.multMaskTB.TabIndex = 12;
            // 
            // findColumnMaskTB
            // 
            this.findColumnMaskTB.Location = new System.Drawing.Point(409, 155);
            this.findColumnMaskTB.Mask = "00";
            this.findColumnMaskTB.Name = "findColumnMaskTB";
            this.findColumnMaskTB.Size = new System.Drawing.Size(31, 20);
            this.findColumnMaskTB.TabIndex = 13;
            // 
            // answerTB
            // 
            this.answerTB.Enabled = false;
            this.answerTB.Location = new System.Drawing.Point(447, 181);
            this.answerTB.Name = "answerTB";
            this.answerTB.Size = new System.Drawing.Size(100, 20);
            this.answerTB.TabIndex = 14;
            this.answerTB.Visible = false;
            // 
            // columnsMaskTB
            // 
            this.columnsMaskTB.Location = new System.Drawing.Point(82, 121);
            this.columnsMaskTB.Mask = "00";
            this.columnsMaskTB.Name = "columnsMaskTB";
            this.columnsMaskTB.Size = new System.Drawing.Size(21, 20);
            this.columnsMaskTB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Строки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Столбцы";
            // 
            // matrixDataGrid3
            // 
            this.matrixDataGrid3.AllowUserToAddRows = false;
            this.matrixDataGrid3.AllowUserToDeleteRows = false;
            this.matrixDataGrid3.AllowUserToResizeColumns = false;
            this.matrixDataGrid3.AllowUserToResizeRows = false;
            this.matrixDataGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixDataGrid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrixDataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGrid3.ColumnHeadersVisible = false;
            this.matrixDataGrid3.EnableHeadersVisualStyles = false;
            this.matrixDataGrid3.Location = new System.Drawing.Point(406, 245);
            this.matrixDataGrid3.Name = "matrixDataGrid3";
            this.matrixDataGrid3.RowHeadersVisible = false;
            this.matrixDataGrid3.Size = new System.Drawing.Size(166, 151);
            this.matrixDataGrid3.TabIndex = 18;
            this.matrixDataGrid3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Матрица C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.matrixDataGrid3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.columnsMaskTB);
            this.Controls.Add(this.answerTB);
            this.Controls.Add(this.findColumnMaskTB);
            this.Controls.Add(this.multMaskTB);
            this.Controls.Add(this.findSumButton);
            this.Controls.Add(this.addMatrButton);
            this.Controls.Add(this.multMatrButton);
            this.Controls.Add(this.randMatrButton);
            this.Controls.Add(this.rowsMaskTB);
            this.Controls.Add(this.randomMatrButton);
            this.Controls.Add(this.creatMatrButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixDataGrid2);
            this.Controls.Add(this.matrixDataGrid1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matrixDataGrid1;
        private System.Windows.Forms.DataGridView matrixDataGrid2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button creatMatrButton;
        private System.Windows.Forms.Button randomMatrButton;
        private System.Windows.Forms.MaskedTextBox rowsMaskTB;
        private System.Windows.Forms.MaskedTextBox randMatrButton;
        private System.Windows.Forms.Button multMatrButton;
        private System.Windows.Forms.Button addMatrButton;
        private System.Windows.Forms.Button findSumButton;
        private System.Windows.Forms.MaskedTextBox multMaskTB;
        private System.Windows.Forms.MaskedTextBox findColumnMaskTB;
        private System.Windows.Forms.TextBox answerTB;
        private System.Windows.Forms.MaskedTextBox columnsMaskTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView matrixDataGrid3;
        private System.Windows.Forms.Label label6;
    }
}

