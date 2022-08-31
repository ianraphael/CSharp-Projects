using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You are {FirstName.Text} {MiddleName.Text} {LastName.Text} and was born on {DatePicker.Text} whose currently having a {Course.Text} course as a {YearLevel.Text}.\n\nThe Program Will Now Close.");
            this.Close();
        }
    }
}
