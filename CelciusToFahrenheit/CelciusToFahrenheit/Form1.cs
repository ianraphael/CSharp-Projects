using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelciusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal celcius = Convert.ToDecimal(textBox1.Text);
                Result.Text = Convert.ToString((celcius * 9 / 5) + 32);

            }
            catch
            {
                Result.Text = "0";
            }
        }
    }
}
