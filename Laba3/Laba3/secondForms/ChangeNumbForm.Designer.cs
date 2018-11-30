namespace Laba3
{
    partial class ChangeNumbForm
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
            this.komplexlabel2 = new System.Windows.Forms.Label();
            this.komplexlabel1 = new System.Windows.Forms.Label();
            this.droblabel2 = new System.Windows.Forms.Label();
            this.droblabel1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.numbLabel = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // komplexlabel2
            // 
            this.komplexlabel2.AutoSize = true;
            this.komplexlabel2.Location = new System.Drawing.Point(46, 248);
            this.komplexlabel2.Name = "komplexlabel2";
            this.komplexlabel2.Size = new System.Drawing.Size(137, 24);
            this.komplexlabel2.TabIndex = 16;
            this.komplexlabel2.Text = "Мнимая часть";
            this.komplexlabel2.Visible = false;
            // 
            // komplexlabel1
            // 
            this.komplexlabel1.AutoSize = true;
            this.komplexlabel1.Location = new System.Drawing.Point(12, 172);
            this.komplexlabel1.Name = "komplexlabel1";
            this.komplexlabel1.Size = new System.Drawing.Size(197, 24);
            this.komplexlabel1.TabIndex = 15;
            this.komplexlabel1.Text = "Вещественная часть";
            this.komplexlabel1.Visible = false;
            // 
            // droblabel2
            // 
            this.droblabel2.AutoSize = true;
            this.droblabel2.Location = new System.Drawing.Point(46, 248);
            this.droblabel2.Name = "droblabel2";
            this.droblabel2.Size = new System.Drawing.Size(131, 24);
            this.droblabel2.TabIndex = 14;
            this.droblabel2.Text = "Знаменатель";
            this.droblabel2.Visible = false;
            // 
            // droblabel1
            // 
            this.droblabel1.AutoSize = true;
            this.droblabel1.Location = new System.Drawing.Point(57, 172);
            this.droblabel1.Name = "droblabel1";
            this.droblabel1.Size = new System.Drawing.Size(105, 24);
            this.droblabel1.TabIndex = 13;
            this.droblabel1.Text = "Числитель";
            this.droblabel1.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(230, 218);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 29);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Изменить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(85, 275);
            this.maskedTextBox2.Mask = "0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(46, 29);
            this.maskedTextBox2.TabIndex = 11;
            this.maskedTextBox2.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(85, 199);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ResetOnPrompt = false;
            this.maskedTextBox1.ResetOnSpace = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(46, 29);
            this.maskedTextBox1.SkipLiterals = false;
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.Visible = false;
            // 
            // numbLabel
            // 
            this.numbLabel.AutoSize = true;
            this.numbLabel.Location = new System.Drawing.Point(104, 21);
            this.numbLabel.Name = "numbLabel";
            this.numbLabel.Size = new System.Drawing.Size(137, 24);
            this.numbLabel.TabIndex = 17;
            this.numbLabel.Text = "Номер записи";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(150, 62);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(32, 29);
            this.maskedTextBox3.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeNumbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.numbLabel);
            this.Controls.Add(this.komplexlabel2);
            this.Controls.Add(this.komplexlabel1);
            this.Controls.Add(this.droblabel2);
            this.Controls.Add(this.droblabel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangeNumbForm";
            this.Text = "ChangeNumbForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label komplexlabel2;
        private System.Windows.Forms.Label komplexlabel1;
        private System.Windows.Forms.Label droblabel2;
        private System.Windows.Forms.Label droblabel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label numbLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Button button1;
    }
}