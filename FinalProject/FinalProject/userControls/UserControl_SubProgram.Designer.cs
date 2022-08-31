namespace FinalProject
{
    partial class UserControl_SubProgram
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemNumberCont = new System.Windows.Forms.TextBox();
            this.NameCont = new System.Windows.Forms.TextBox();
            this.QuantityCont = new System.Windows.Forms.TextBox();
            this.PriceCont = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Items";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(22, 270);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(207, 35);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "Show Items";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Item Number:";
            // 
            // ItemNumberCont
            // 
            this.ItemNumberCont.Location = new System.Drawing.Point(22, 91);
            this.ItemNumberCont.Name = "ItemNumberCont";
            this.ItemNumberCont.Size = new System.Drawing.Size(207, 23);
            this.ItemNumberCont.TabIndex = 3;
            // 
            // NameCont
            // 
            this.NameCont.Location = new System.Drawing.Point(22, 139);
            this.NameCont.Name = "NameCont";
            this.NameCont.Size = new System.Drawing.Size(207, 23);
            this.NameCont.TabIndex = 3;
            // 
            // QuantityCont
            // 
            this.QuantityCont.Location = new System.Drawing.Point(22, 187);
            this.QuantityCont.Name = "QuantityCont";
            this.QuantityCont.Size = new System.Drawing.Size(207, 23);
            this.QuantityCont.TabIndex = 3;
            // 
            // PriceCont
            // 
            this.PriceCont.Location = new System.Drawing.Point(22, 235);
            this.PriceCont.Name = "PriceCont";
            this.PriceCont.Size = new System.Drawing.Size(207, 23);
            this.PriceCont.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(434, 337);
            this.dataGridView1.TabIndex = 4;
            // 
            // UserControl_SubProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PriceCont);
            this.Controls.Add(this.QuantityCont);
            this.Controls.Add(this.NameCont);
            this.Controls.Add(this.ItemNumberCont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_SubProgram";
            this.Size = new System.Drawing.Size(704, 442);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemNumberCont;
        private System.Windows.Forms.TextBox NameCont;
        private System.Windows.Forms.TextBox QuantityCont;
        private System.Windows.Forms.TextBox PriceCont;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
