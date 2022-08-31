namespace Numbergame
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
            this.label1 = new System.Windows.Forms.Label();
            this.GuessInput = new System.Windows.Forms.TextBox();
            this.Chance = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a guess number from 1 to 100";
            // 
            // GuessInput
            // 
            this.GuessInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuessInput.Location = new System.Drawing.Point(139, 33);
            this.GuessInput.Name = "GuessInput";
            this.GuessInput.Size = new System.Drawing.Size(161, 35);
            this.GuessInput.TabIndex = 1;
            this.GuessInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Chance
            // 
            this.Chance.AutoSize = true;
            this.Chance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chance.Location = new System.Drawing.Point(168, 161);
            this.Chance.Name = "Chance";
            this.Chance.Size = new System.Drawing.Size(102, 25);
            this.Chance.TabIndex = 2;
            this.Chance.Text = "Chances: 0";
            this.Chance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(168, 70);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(102, 41);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(91, 187);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(257, 110);
            this.Result.TabIndex = 4;
            this.Result.Text = "Result";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessBtn
            // 
            this.GuessBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuessBtn.Location = new System.Drawing.Point(168, 117);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(102, 41);
            this.GuessBtn.TabIndex = 3;
            this.GuessBtn.Text = "Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 327);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Chance);
            this.Controls.Add(this.GuessInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GuessInput;
        private System.Windows.Forms.Label Chance;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button GuessBtn;
    }
}
