using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExercise1
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
                // turning base date to a string
                string baseDate = dateTimePicker1.Value.ToShortDateString();
                string baseDay = baseDate.Substring(0, 2);
                string baseMonth = baseDate.Substring(3, 2);
                string baseYear = baseDate.Substring(6);
                //turning birth date to a string
                string birthDate = textBox1.Text.Trim();
                string birthDay = birthDate.Substring(0, 2);
                string birthMonth = birthDate.Substring(3, birthDate.Length - 8);
                string birthYear = birthDate.Substring(birthDate.Length - 4);
                int birthMonthNumber = 0;
                switch (birthMonth)
                {
                    case "January": birthMonthNumber = 1; break;
                    case "February": birthMonthNumber = 2; break;
                    case "March": birthMonthNumber = 3; break;
                    case "April": birthMonthNumber = 4; break;
                    case "May": birthMonthNumber = 5; break;
                    case "June": birthMonthNumber = 6; break;
                    case "July": birthMonthNumber = 7; break;
                    case "August": birthMonthNumber = 8; break;
                    case "September": birthMonthNumber = 9; break;
                    case "October": birthMonthNumber = 10; break;
                    case "November": birthMonthNumber = 11; break;
                    case "December": birthMonthNumber = 12; break;
                    default: break;
                }
                // the result
                int ageInDay = Convert.ToInt32(baseDay) - Convert.ToInt32(birthDay);
                int ageInMonth = Convert.ToInt32(baseMonth) - birthMonthNumber;
                int ageInYear = Convert.ToInt32(baseYear) - Convert.ToInt32(birthYear);
                if (ageInDay < 0)
                {
                    ageInMonth -= 1;
                    ageInDay = 31 - Math.Abs(ageInDay);
                }
                if (ageInMonth < 0)
                {
                    ageInYear -= 1;
                    ageInMonth = 12 - Math.Abs(ageInMonth);
                }

                textBox2.Text = $"{ageInYear} year(s), {ageInMonth} Month(s) and {ageInDay} day(s)";
            }
            catch
            {
                textBox2.Text = "Waiting for proper format";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}