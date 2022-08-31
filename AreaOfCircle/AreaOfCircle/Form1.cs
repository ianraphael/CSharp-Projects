using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfCircle
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
                double radius = Convert.ToDouble(Radius.Text);
                result.Text = Convert.ToString(3.14 * Math.Pow(radius, 2));
            }
            catch
            {

            }
        }
        private void Radius_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
