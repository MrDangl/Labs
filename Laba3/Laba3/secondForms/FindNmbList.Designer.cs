namespace Laba3
{
    partial class FindNmbList
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
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.numbLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(112, 64);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(32, 29);
            this.maskedTextBox3.TabIndex = 20;
            // 
            // numbLabel
            // 
            this.numbLabel.AutoSize = true;
            this.numbLabel.Location = new System.Drawing.Point(66, 23);
            this.numbLabel.Name = "numbLabel";
            this.numbLabel.Size = new System.Drawing.Size(137, 24);
            this.numbLabel.TabIndex = 19;
            this.numbLabel.Text = "Номер записи";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Найти запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindNmbList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.numbLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FindNmbList";
            this.Text = "FindNmbList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label numbLabel;
        private System.Windows.Forms.Button button1;
    }
}