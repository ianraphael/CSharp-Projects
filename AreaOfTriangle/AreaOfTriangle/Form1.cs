using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfTriangle
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
                decimal myBase = Convert.ToDecimal(Base.Text);
                decimal myHeight = Convert.ToDecimal(Height.Text);
                result.Text = Convert.ToString(myBase * myHeight / 2);
            }catch
            {

            }
        }
        private void Height_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void Base_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
