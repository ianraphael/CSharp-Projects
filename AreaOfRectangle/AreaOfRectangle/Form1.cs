using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {
            try
            {
                decimal myWidth = Convert.ToDecimal(Width.Text);
                decimal myLenght = Convert.ToDecimal(Length.Text);
                result.Text = Convert.ToString(myWidth * myLenght);
            }
            catch
            {

            }
        }
        private void Width_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void Height_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
