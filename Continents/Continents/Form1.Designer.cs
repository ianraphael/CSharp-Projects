namespace Continents
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
            this.ContinentList = new System.Windows.Forms.ListBox();
            this.CountryList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContinentList
            // 
            this.ContinentList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContinentList.FormattingEnabled = true;
            this.ContinentList.ItemHeight = 25;
            this.ContinentList.Items.AddRange(new object[] {
            "Asia",
            "Africa",
            "North America",
            "South America",
            "Antarctica",
            "Europe",
            "Australia"});
            this.ContinentList.Location = new System.Drawing.Point(53, 71);
            this.ContinentList.Name = "ContinentList";
            this.ContinentList.Size = new System.Drawing.Size(182, 179);
            this.ContinentList.TabIndex = 0;
            this.ContinentList.SelectedIndexChanged += new System.EventHandler(this.ContinentList_SelectedIndexChanged);
            // 
            // CountryList
            // 
            this.CountryList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryList.FormattingEnabled = true;
            this.CountryList.ItemHeight = 25;
            this.CountryList.Location = new System.Drawing.Point(351, 71);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(219, 254);
            this.CountryList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Continents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(413, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Countries";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(53, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 146);
            this.label3.TabIndex = 1;
            this.label3.Text = "This program allows you to select a continent and see top 10 countries with highe" +
    "st population from it.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryList);
            this.Controls.Add(this.ContinentList);
            this.Name = "Form1";
            this.Text = "Continents and Countries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ContinentList;
        private System.Windows.Forms.ListBox CountryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
