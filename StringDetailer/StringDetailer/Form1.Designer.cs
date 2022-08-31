namespace StringDetailer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StringLength = new System.Windows.Forms.Label();
            this.Consonants = new System.Windows.Forms.Label();
            this.Vowels = new System.Windows.Forms.Label();
            this.Reversed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a word here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "The length of the stirng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number consonants from the string:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numbers vowels from the string: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "The string in reversed form: ";
            // 
            // StringLength
            // 
            this.StringLength.AutoSize = true;
            this.StringLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StringLength.ForeColor = System.Drawing.Color.DarkGreen;
            this.StringLength.Location = new System.Drawing.Point(12, 108);
            this.StringLength.Name = "StringLength";
            this.StringLength.Size = new System.Drawing.Size(68, 24);
            this.StringLength.TabIndex = 2;
            this.StringLength.Text = "Length";
            // 
            // Consonants
            // 
            this.Consonants.AutoSize = true;
            this.Consonants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Consonants.ForeColor = System.Drawing.Color.DarkGreen;
            this.Consonants.Location = new System.Drawing.Point(12, 160);
            this.Consonants.Name = "Consonants";
            this.Consonants.Size = new System.Drawing.Size(68, 24);
            this.Consonants.TabIndex = 2;
            this.Consonants.Text = "Length";
            // 
            // Vowels
            // 
            this.Vowels.AutoSize = true;
            this.Vowels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vowels.ForeColor = System.Drawing.Color.DarkGreen;
            this.Vowels.Location = new System.Drawing.Point(12, 210);
            this.Vowels.Name = "Vowels";
            this.Vowels.Size = new System.Drawing.Size(68, 24);
            this.Vowels.TabIndex = 2;
            this.Vowels.Text = "Length";
            // 
            // Reversed
            // 
            this.Reversed.AutoSize = true;
            this.Reversed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reversed.ForeColor = System.Drawing.Color.DarkGreen;
            this.Reversed.Location = new System.Drawing.Point(12, 264);
            this.Reversed.Name = "Reversed";
            this.Reversed.Size = new System.Drawing.Size(68, 24);
            this.Reversed.TabIndex = 2;
            this.Reversed.Text = "Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 302);
            this.Controls.Add(this.Reversed);
            this.Controls.Add(this.Vowels);
            this.Controls.Add(this.Consonants);
            this.Controls.Add(this.StringLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "String Detailer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StringLength;
        private System.Windows.Forms.Label Consonants;
        private System.Windows.Forms.Label Vowels;
        private System.Windows.Forms.Label Reversed;
    }
}
