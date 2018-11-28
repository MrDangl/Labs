namespace Laba3
{
    partial class AddNumbForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.droblabel1 = new System.Windows.Forms.Label();
            this.droblabel2 = new System.Windows.Forms.Label();
            this.komplexlabel1 = new System.Windows.Forms.Label();
            this.komplexlabel2 = new System.Windows.Forms.Label();
            this.drobRadioButton = new System.Windows.Forms.RadioButton();
            this.komplexRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(96, 129);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ResetOnPrompt = false;
            this.maskedTextBox1.ResetOnSpace = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(46, 29);
            this.maskedTextBox1.SkipLiterals = false;
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.Visible = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(96, 205);
            this.maskedTextBox2.Mask = "0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(46, 29);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(312, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "button1";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите один из типов значений";
            // 
            // droblabel1
            // 
            this.droblabel1.AutoSize = true;
            this.droblabel1.Location = new System.Drawing.Point(68, 102);
            this.droblabel1.Name = "droblabel1";
            this.droblabel1.Size = new System.Drawing.Size(105, 24);
            this.droblabel1.TabIndex = 6;
            this.droblabel1.Text = "Числитель";
            this.droblabel1.Visible = false;
            // 
            // droblabel2
            // 
            this.droblabel2.AutoSize = true;
            this.droblabel2.Location = new System.Drawing.Point(57, 178);
            this.droblabel2.Name = "droblabel2";
            this.droblabel2.Size = new System.Drawing.Size(131, 24);
            this.droblabel2.TabIndex = 7;
            this.droblabel2.Text = "Знаменатель";
            this.droblabel2.Visible = false;
            // 
            // komplexlabel1
            // 
            this.komplexlabel1.AutoSize = true;
            this.komplexlabel1.Location = new System.Drawing.Point(23, 102);
            this.komplexlabel1.Name = "komplexlabel1";
            this.komplexlabel1.Size = new System.Drawing.Size(197, 24);
            this.komplexlabel1.TabIndex = 8;
            this.komplexlabel1.Text = "Вещественная часть";
            this.komplexlabel1.Visible = false;
            // 
            // komplexlabel2
            // 
            this.komplexlabel2.AutoSize = true;
            this.komplexlabel2.Location = new System.Drawing.Point(57, 178);
            this.komplexlabel2.Name = "komplexlabel2";
            this.komplexlabel2.Size = new System.Drawing.Size(137, 24);
            this.komplexlabel2.TabIndex = 9;
            this.komplexlabel2.Text = "Мнимая часть";
            this.komplexlabel2.Visible = false;
            // 
            // drobRadioButton
            // 
            this.drobRadioButton.AutoSize = true;
            this.drobRadioButton.Location = new System.Drawing.Point(27, 27);
            this.drobRadioButton.Name = "drobRadioButton";
            this.drobRadioButton.Size = new System.Drawing.Size(217, 28);
            this.drobRadioButton.TabIndex = 10;
            this.drobRadioButton.TabStop = true;
            this.drobRadioButton.Text = "Рациональная дробь";
            this.drobRadioButton.UseVisualStyleBackColor = true;
            this.drobRadioButton.CheckedChanged += new System.EventHandler(this.drobRadioButton_CheckedChanged);
            // 
            // komplexRadioButton
            // 
            this.komplexRadioButton.AutoSize = true;
            this.komplexRadioButton.Location = new System.Drawing.Point(293, 27);
            this.komplexRadioButton.Name = "komplexRadioButton";
            this.komplexRadioButton.Size = new System.Drawing.Size(205, 28);
            this.komplexRadioButton.TabIndex = 11;
            this.komplexRadioButton.TabStop = true;
            this.komplexRadioButton.Text = "Комплексное число";
            this.komplexRadioButton.UseVisualStyleBackColor = true;
            this.komplexRadioButton.CheckedChanged += new System.EventHandler(this.komplexRadioButton_CheckedChanged);
            // 
            // AddNumbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 250);
            this.Controls.Add(this.komplexRadioButton);
            this.Controls.Add(this.drobRadioButton);
            this.Controls.Add(this.komplexlabel2);
            this.Controls.Add(this.komplexlabel1);
            this.Controls.Add(this.droblabel2);
            this.Controls.Add(this.droblabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddNumbForm";
            this.Text = "Добавить число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label droblabel1;
        private System.Windows.Forms.Label droblabel2;
        private System.Windows.Forms.Label komplexlabel1;
        private System.Windows.Forms.Label komplexlabel2;
        private System.Windows.Forms.RadioButton drobRadioButton;
        private System.Windows.Forms.RadioButton komplexRadioButton;
    }
}