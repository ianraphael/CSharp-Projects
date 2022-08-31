namespace OrderPizza
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
            this.Regular = new System.Windows.Forms.RadioButton();
            this.Special = new System.Windows.Forms.RadioButton();
            this.Cheese = new System.Windows.Forms.CheckBox();
            this.Pepper = new System.Windows.Forms.CheckBox();
            this.BaconAndHam = new System.Windows.Forms.CheckBox();
            this.Mushroom = new System.Windows.Forms.CheckBox();
            this.OnionsAndChili = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.Extra = new System.Windows.Forms.RadioButton();
            this.Tomato = new System.Windows.Forms.CheckBox();
            this.Mayo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Regular
            // 
            this.Regular.AutoSize = true;
            this.Regular.BackColor = System.Drawing.Color.MediumPurple;
            this.Regular.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Regular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Regular.Location = new System.Drawing.Point(57, 67);
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(95, 29);
            this.Regular.TabIndex = 0;
            this.Regular.TabStop = true;
            this.Regular.Text = "Regular";
            this.Regular.UseVisualStyleBackColor = false;
            this.Regular.CheckedChanged += new System.EventHandler(this.Regular_CheckedChanged);
            // 
            // Special
            // 
            this.Special.AutoSize = true;
            this.Special.BackColor = System.Drawing.Color.MediumPurple;
            this.Special.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Special.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Special.Location = new System.Drawing.Point(57, 100);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(90, 29);
            this.Special.TabIndex = 0;
            this.Special.TabStop = true;
            this.Special.Text = "Special";
            this.Special.UseVisualStyleBackColor = false;
            this.Special.CheckedChanged += new System.EventHandler(this.Special_CheckedChanged_1);
            // 
            // Cheese
            // 
            this.Cheese.AutoSize = true;
            this.Cheese.BackColor = System.Drawing.Color.Coral;
            this.Cheese.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Cheese.Location = new System.Drawing.Point(211, 44);
            this.Cheese.Name = "Cheese";
            this.Cheese.Size = new System.Drawing.Size(79, 25);
            this.Cheese.TabIndex = 1;
            this.Cheese.Text = "Cheese";
            this.Cheese.UseVisualStyleBackColor = false;
            // 
            // Pepper
            // 
            this.Pepper.AutoSize = true;
            this.Pepper.BackColor = System.Drawing.Color.Coral;
            this.Pepper.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Pepper.Location = new System.Drawing.Point(211, 80);
            this.Pepper.Name = "Pepper";
            this.Pepper.Size = new System.Drawing.Size(79, 25);
            this.Pepper.TabIndex = 1;
            this.Pepper.Text = "Pepper";
            this.Pepper.UseVisualStyleBackColor = false;
            // 
            // BaconAndHam
            // 
            this.BaconAndHam.AutoSize = true;
            this.BaconAndHam.BackColor = System.Drawing.Color.Coral;
            this.BaconAndHam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BaconAndHam.Location = new System.Drawing.Point(211, 116);
            this.BaconAndHam.Name = "BaconAndHam";
            this.BaconAndHam.Size = new System.Drawing.Size(143, 25);
            this.BaconAndHam.TabIndex = 1;
            this.BaconAndHam.Text = "Bacon and Ham";
            this.BaconAndHam.UseVisualStyleBackColor = false;
            // 
            // Mushroom
            // 
            this.Mushroom.AutoSize = true;
            this.Mushroom.BackColor = System.Drawing.Color.Coral;
            this.Mushroom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Mushroom.Location = new System.Drawing.Point(211, 152);
            this.Mushroom.Name = "Mushroom";
            this.Mushroom.Size = new System.Drawing.Size(106, 25);
            this.Mushroom.TabIndex = 1;
            this.Mushroom.Text = "Mushroom";
            this.Mushroom.UseVisualStyleBackColor = false;
            // 
            // OnionsAndChili
            // 
            this.OnionsAndChili.AutoSize = true;
            this.OnionsAndChili.BackColor = System.Drawing.Color.Coral;
            this.OnionsAndChili.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OnionsAndChili.Location = new System.Drawing.Point(211, 188);
            this.OnionsAndChili.Name = "OnionsAndChili";
            this.OnionsAndChili.Size = new System.Drawing.Size(149, 25);
            this.OnionsAndChili.TabIndex = 1;
            this.OnionsAndChili.Text = "Onions and Chili";
            this.OnionsAndChili.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Brown;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.Brown;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quantity.Location = new System.Drawing.Point(104, 216);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(84, 29);
            this.Quantity.TabIndex = 3;
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.TextChanged += new System.EventHandler(this.Quantity_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Brown;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(104, 181);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(54, 25);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Brown;
            this.Total.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(104, 299);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(53, 25);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total";
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.Brown;
            this.OrderBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderBtn.Location = new System.Drawing.Point(35, 255);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(137, 38);
            this.OrderBtn.TabIndex = 4;
            this.OrderBtn.Text = "COMPUTE";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // Extra
            // 
            this.Extra.AutoSize = true;
            this.Extra.BackColor = System.Drawing.Color.MediumPurple;
            this.Extra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Extra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Extra.Location = new System.Drawing.Point(57, 133);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(79, 29);
            this.Extra.TabIndex = 0;
            this.Extra.TabStop = true;
            this.Extra.Text = " Extra";
            this.Extra.UseVisualStyleBackColor = false;
            this.Extra.CheckedChanged += new System.EventHandler(this.Extra_CheckedChanged_1);
            // 
            // Tomato
            // 
            this.Tomato.AutoSize = true;
            this.Tomato.BackColor = System.Drawing.Color.Coral;
            this.Tomato.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Tomato.Location = new System.Drawing.Point(211, 224);
            this.Tomato.Name = "Tomato";
            this.Tomato.Size = new System.Drawing.Size(85, 25);
            this.Tomato.TabIndex = 1;
            this.Tomato.Text = "Tomato";
            this.Tomato.UseVisualStyleBackColor = false;
            // 
            // Mayo
            // 
            this.Mayo.AutoSize = true;
            this.Mayo.BackColor = System.Drawing.Color.Coral;
            this.Mayo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Mayo.Location = new System.Drawing.Point(211, 260);
            this.Mayo.Name = "Mayo";
            this.Mayo.Size = new System.Drawing.Size(69, 25);
            this.Mayo.TabIndex = 1;
            this.Mayo.Text = "Mayo";
            this.Mayo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Burger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 366);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mayo);
            this.Controls.Add(this.Tomato);
            this.Controls.Add(this.OnionsAndChili);
            this.Controls.Add(this.Mushroom);
            this.Controls.Add(this.BaconAndHam);
            this.Controls.Add(this.Pepper);
            this.Controls.Add(this.Cheese);
            this.Controls.Add(this.Extra);
            this.Controls.Add(this.Special);
            this.Controls.Add(this.Regular);
            this.Name = "Form1";
            this.Text = "Burger Express";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Regular;
        private System.Windows.Forms.RadioButton Special;
        private System.Windows.Forms.CheckBox Cheese;
        private System.Windows.Forms.CheckBox Pepper;
        private System.Windows.Forms.CheckBox BaconAndHam;
        private System.Windows.Forms.CheckBox Mushroom;
        private System.Windows.Forms.CheckBox OnionsAndChili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.RadioButton Extra;
        private System.Windows.Forms.CheckBox Tomato;
        private System.Windows.Forms.CheckBox Mayo;
        private System.Windows.Forms.Label label1;
    }
}
