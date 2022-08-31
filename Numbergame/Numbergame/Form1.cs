using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbergame
{
    public partial class Form1 : Form
    {
        int chances;
        private int random;
        public Form1()
        {
            InitializeComponent();
            Restart();
            random = RandomNumber();
            Chance.Text = $"Chances: {chances}";
            Result.Text = "Click Start to begin.";
        }
        private int RandomNumber()
        {
            Random random = new Random();
            return random.Next(100) + 1;
        }
        public void Restart()
        {
            GuessInput.Enabled = false;
            GuessBtn.Enabled = false;
            StartBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            GuessInput.Enabled = true;
            GuessBtn.Enabled = true;
            chances = 5;
            Chance.Text = $"Chances: {chances}";
            Result.Text = "Goodluck!";
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(GuessInput.Text);
            chances--;
            if (chances > 0)
            {
                GuessInput.Enabled = true;
                GuessBtn.Enabled = true;
                Chance.Text = $"Chances: {chances}";
                if (guess == random)
                {
                    Restart();
                    Result.Text = $"{guess} is korique.";
                }
                else if (guess > random)
                {
                    GuessInput.Text = null;
                    Result.Text = $"{guess} is too high.";
                }else if (guess < random)
                {
                    GuessInput.Text = null;
                    Result.Text = $"{guess} is too low";
                }
            }
            else
            {
                Restart();
                Chance.Text = $"Chances: {chances}";
                Result.Text = $"You lose vv!\nThe right answer is {random}";
            }

        }
    }
}
