namespace Laba3
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addNumb = new System.Windows.Forms.ToolStripMenuItem();
            this.changeNumb = new System.Windows.Forms.ToolStripMenuItem();
            this.showList = new System.Windows.Forms.ToolStripMenuItem();
            this.failToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.writeTolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNumb,
            this.changeNumb,
            this.showList,
            this.failToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Меню";
            // 
            // addNumb
            // 
            this.addNumb.Name = "addNumb";
            this.addNumb.Size = new System.Drawing.Size(108, 20);
            this.addNumb.Text = "Добавить число";
            // 
            // changeNumb
            // 
            this.changeNumb.Name = "changeNumb";
            this.changeNumb.Size = new System.Drawing.Size(110, 20);
            this.changeNumb.Text = "Изменить число";
            // 
            // showList
            // 
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(105, 20);
            this.showList.Text = "Показать числа";
            // 
            // failToolStrip
            // 
            this.failToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeTolStrip,
            this.openToolStrip});
            this.failToolStrip.Name = "failToolStrip";
            this.failToolStrip.Size = new System.Drawing.Size(48, 20);
            this.failToolStrip.Text = "Фаил";
            // 
            // writeTolStrip
            // 
            this.writeTolStrip.Name = "writeTolStrip";
            this.writeTolStrip.Size = new System.Drawing.Size(124, 22);
            this.writeTolStrip.Text = "Записать";
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.Size = new System.Drawing.Size(124, 22);
            this.openToolStrip.Text = "Открыть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
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
    }
}

