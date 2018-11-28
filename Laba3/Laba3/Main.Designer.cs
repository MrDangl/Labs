namespace Laba3
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.failToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.writeTolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addNumb = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNumb = new System.Windows.Forms.ToolStripMenuItem();
            this.showList = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failToolStrip,
            this.addNumb,
            this.changeNumb,
            this.showList,
            this.findToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(737, 37);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // failToolStrip
            // 
            this.failToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeTolStrip,
            this.openToolStrip});
            this.failToolStrip.Name = "failToolStrip";
            this.failToolStrip.Size = new System.Drawing.Size(69, 29);
            this.failToolStrip.Text = "Фаил";
            // 
            // writeTolStrip
            // 
            this.writeTolStrip.Name = "writeTolStrip";
            this.writeTolStrip.Size = new System.Drawing.Size(163, 30);
            this.writeTolStrip.Text = "Записать";
            this.writeTolStrip.Click += new System.EventHandler(this.writeTolStrip_Click);
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.Size = new System.Drawing.Size(163, 30);
            this.openToolStrip.Text = "Открыть";
            this.openToolStrip.Click += new System.EventHandler(this.openToolStrip_Click);
            // 
            // addNumb
            // 
            this.addNumb.Name = "addNumb";
            this.addNumb.Size = new System.Drawing.Size(165, 29);
            this.addNumb.Text = "Добавить число";
            this.addNumb.Click += new System.EventHandler(this.addNumb_Click);
            // 
            // changeNumb
            // 
            this.changeNumb.Name = "changeNumb";
            this.changeNumb.Size = new System.Drawing.Size(166, 29);
            this.changeNumb.Text = "Изменить число";
            this.changeNumb.Click += new System.EventHandler(this.changeNumb_Click);
            // 
            // showList
            // 
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(160, 29);
            this.showList.Text = "Показать числа";
            this.showList.Click += new System.EventHandler(this.showList_Click);
            // 
            // findToolStrip
            // 
            this.findToolStrip.Name = "findToolStrip";
            this.findToolStrip.Size = new System.Drawing.Size(141, 29);
            this.findToolStrip.Text = "Найти запись";
            this.findToolStrip.Click += new System.EventHandler(this.findToolStrip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Разработать все классы иерархии и Windows - приложение для добавления, \r\nввода по" +
    " 2 объекта каждого класса, просмотра всех объектов, \r\nвыдачи запроса, записи объ" +
    "ектов в файл и чтения их из файла\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.\tКомплексные (действительная и мнимая части – пара действительных чисел)\r\nПрост" +
    "ые дроби (числитель, знаменатель - пара целых чисел)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Лабараторная 3";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNumb;
        private System.Windows.Forms.ToolStripMenuItem changeNumb;
        private System.Windows.Forms.ToolStripMenuItem showList;
        private System.Windows.Forms.ToolStripMenuItem failToolStrip;
        private System.Windows.Forms.ToolStripMenuItem writeTolStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStrip;
        private System.Windows.Forms.ToolStripMenuItem findToolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

