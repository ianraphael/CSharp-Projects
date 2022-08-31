using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double percentile = Convert.ToDouble(percentileCont.Text);
            if (percentile <= 100 && percentile >= 98)
            {
                transcriptCont.Text = Convert.ToString(1.00);
            }else if(percentile <= 97 && percentile >= 95)
            {
                transcriptCont.Text = Convert.ToString(1.25);
            }else if (percentile <= 94 && percentile >= 92)
            {
                transcriptCont.Text = Convert.ToString(1.50);
            }else if (percentile <= 91 && percentile >= 89)
            {
                transcriptCont.Text = Convert.ToString(1.75);
            }else if (percentile <= 88 && percentile >= 85)
            {
                transcriptCont.Text = Convert.ToString(2);
            }else if (percentile <= 84 && percentile >= 82)
            {
                transcriptCont.Text = Convert.ToString(2.25);
            }else if (percentile <= 81 && percentile >= 80)
            {
                transcriptCont.Text = Convert.ToString(2.50);
            }else if (percentile <= 79 && percentile >= 77)
            {
                transcriptCont.Text = Convert.ToString(2.75);
            }
            else if (percentile <= 76 && percentile >= 75)
            {
                transcriptCont.Text = Convert.ToString(3);
            }else
            {
                transcriptCont.Text = "Out of Range";
            }

        }
    }
}
