using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = inputCont.Text;
            if (input == "a" || input == "A" || input == "e" || input == "E" || input == "i" || input == "I" || input == "o" || input == "O" || input == "u" || input == "U")
            {
                outputCont.Text = "Vowel";
            }else
            {
                outputCont.Text = "Consonant";
            }
        }
    }
}
