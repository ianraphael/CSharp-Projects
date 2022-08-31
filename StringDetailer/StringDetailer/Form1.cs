using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringDetailer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string theString = textBox1.Text;
            StringLength.Text = theString.Length.ToString();
            int consonants = 0;
            int vowels = 0;
            foreach (char letter in theString.ToLower())
            {
                if (char.IsLetter(letter))
                {
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                        vowels++;
                    else 
                        consonants++;
                }
            }
            Consonants.Text = consonants.ToString();
            Vowels.Text = vowels.ToString();
            IList<char> letterList = new List<char>();
            foreach (char letter in theString)
            {
                letterList.Add(letter);
            }
            string reversed = null;
            foreach (char letter in letterList.Reverse())
            {
                reversed += letter;

            }
            Reversed.Text = reversed;
        }
    }
}
