namespace FinalProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subprogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl_About1 = new FinalProject.userControls.UserControl_About();
            this.userControl_SubProgram1 = new FinalProject.UserControl_SubProgram();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.subprogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // subprogramToolStripMenuItem
            // 
            this.subprogramToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subprogramToolStripMenuItem.Name = "subprogramToolStripMenuItem";
            this.subprogramToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.subprogramToolStripMenuItem.Text = "Sub-program";
            this.subprogramToolStripMenuItem.Click += new System.EventHandler(this.subprogramToolStripMenuItem_Click);
            // 
            // userControl_About1
            // 
            this.userControl_About1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.userControl_About1.Location = new System.Drawing.Point(26, 46);
            this.userControl_About1.Name = "userControl_About1";
            this.userControl_About1.Size = new System.Drawing.Size(580, 363);
            this.userControl_About1.TabIndex = 1;
            // 
            // userControl_SubProgram1
            // 
            this.userControl_SubProgram1.Location = new System.Drawing.Point(26, 36);
            this.userControl_SubProgram1.Name = "userControl_SubProgram1";
            this.userControl_SubProgram1.Size = new System.Drawing.Size(704, 442);
            this.userControl_SubProgram1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 479);
            this.Controls.Add(this.userControl_SubProgram1);
            this.Controls.Add(this.userControl_About1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Final Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subprogramToolStripMenuItem;
        private userControls.UserControl_About userControl_About1;
        private UserControl_SubProgram userControl_SubProgram1;
    }
}
