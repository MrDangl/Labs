namespace Laba4
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelzapros1 = new System.Windows.Forms.Label();
            this.labelzapros2 = new System.Windows.Forms.Label();
            this.labelzapros3 = new System.Windows.Forms.Label();
            this.labelzapros4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.middleButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 25);
            this.toolStripMenuItem1.Text = "Запрос 1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 25);
            this.toolStripMenuItem2.Text = "Запрос 2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 25);
            this.toolStripMenuItem3.Text = "Запрос 3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 25);
            this.toolStripMenuItem4.Text = "Запрос 4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(553, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelzapros1
            // 
            this.labelzapros1.AutoSize = true;
            this.labelzapros1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelzapros1.Location = new System.Drawing.Point(12, 43);
            this.labelzapros1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelzapros1.Name = "labelzapros1";
            this.labelzapros1.Size = new System.Drawing.Size(448, 40);
            this.labelzapros1.TabIndex = 0;
            this.labelzapros1.Text = "Выполнение запроса над числовым массивом вариант 3. \r\nНайти произведение четных э" +
    "лементов\r\n";
            // 
            // labelzapros2
            // 
            this.labelzapros2.AutoSize = true;
            this.labelzapros2.Location = new System.Drawing.Point(12, 104);
            this.labelzapros2.Name = "labelzapros2";
            this.labelzapros2.Size = new System.Drawing.Size(451, 40);
            this.labelzapros2.TabIndex = 2;
            this.labelzapros2.Text = "Выполнение запроса над строковым массивом вариант 4.\r\nНайти строки, являющиеся из" +
    "ображениями чисел";
            // 
            // labelzapros3
            // 
            this.labelzapros3.AutoSize = true;
            this.labelzapros3.Location = new System.Drawing.Point(12, 166);
            this.labelzapros3.Name = "labelzapros3";
            this.labelzapros3.Size = new System.Drawing.Size(536, 60);
            this.labelzapros3.TabIndex = 3;
            this.labelzapros3.Text = "Выполнение запроса над коллекцией-массивом объектов вариант 1.\r\nлекарства запрос:" +
    " Определить общую цену \r\nопределенного лекарства по всем аптекам\r\n";
            // 
            // labelzapros4
            // 
            this.labelzapros4.AutoSize = true;
            this.labelzapros4.Location = new System.Drawing.Point(12, 246);
            this.labelzapros4.Name = "labelzapros4";
            this.labelzapros4.Size = new System.Drawing.Size(351, 60);
            this.labelzapros4.TabIndex = 4;
            this.labelzapros4.Text = "Выполнение двух запросов  над двумя\r\n коллекциями-списками объектов вариант 5.\r\n " +
    "книги  и читатели \r\n";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 244);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(92, 382);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(100, 27);
            this.leftButton.TabIndex = 6;
            this.leftButton.Text = "button1";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Visible = false;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // middleButton
            // 
            this.middleButton.Location = new System.Drawing.Point(242, 383);
            this.middleButton.Name = "middleButton";
            this.middleButton.Size = new System.Drawing.Size(100, 27);
            this.middleButton.TabIndex = 7;
            this.middleButton.Text = "button1";
            this.middleButton.UseVisualStyleBackColor = true;
            this.middleButton.Visible = false;
            this.middleButton.Click += new System.EventHandler(this.middleButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(387, 383);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(97, 27);
            this.rightButton.TabIndex = 8;
            this.rightButton.Text = "button1";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Visible = false;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Найти";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.middleButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.labelzapros4);
            this.Controls.Add(this.labelzapros3);
            this.Controls.Add(this.labelzapros2);
            this.Controls.Add(this.labelzapros1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelzapros1;
        private System.Windows.Forms.Label labelzapros2;
        private System.Windows.Forms.Label labelzapros3;
        private System.Windows.Forms.Label labelzapros4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button middleButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

