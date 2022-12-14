using System;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public void Calculate()
        {
            if (Quantity.Text.Length != 0)
                Total.Text = Convert.ToString(Convert.ToInt32(Quantity.Text) * Convert.ToInt32(Price.Text));
            else
                Total.Text = Price.Text;
        }
        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void Regular_CheckedChanged(object sender, EventArgs e)
        {
            Cheese.Checked = true;
            Pepper.Checked = false;
            BaconAndHam.Checked = true;
            Mushroom.Checked = false;
            OnionsAndChili.Checked = true;
            Tomato.Checked = false;
            Mayo.Checked = false;
            Price.Text = "250";
            Calculate();
        }
        private void Special_CheckedChanged_1(object sender, EventArgs e)
        {
            Cheese.Checked = true;
            Pepper.Checked = true;
            BaconAndHam.Checked = true;
            Mushroom.Checked = true;
            OnionsAndChili.Checked = true;
            Tomato.Checked = false;
            Mayo.Checked = false;
            Price.Text = "315";
            Calculate();
        }
        private void Extra_CheckedChanged_1(object sender, EventArgs e)
        {
            Cheese.Checked = true;
            Pepper.Checked = true;
            BaconAndHam.Checked = true;
            Mushroom.Checked = true;
            OnionsAndChili.Checked = true;
            Tomato.Checked = false;
            Mayo.Checked = false;
            Price.Text = "390";
            Calculate();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the program.\nThis is not yet fully working.\nThe program will now close.");
            this.Close();
        }
    }
}
