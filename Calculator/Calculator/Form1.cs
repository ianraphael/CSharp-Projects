using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
		string prevSign = null;
        public Form1()
        {
            InitializeComponent();
			var buttons = GetButtons(this, typeof(Button));

			foreach (var button in buttons)
			{
				button.Click += CheckText_Click;
			}
		}
		private void CheckText_Click(object sender, EventArgs e)
        {
			string btnText = sender.ToString()[(sender.ToString().IndexOf(':') + 2)..];
			switch (btnText)
            {
				case "1": Input(btnText); break;
				case "2": Input(btnText); break;
				case "3": Input(btnText); break;
				case "4": Input(btnText); break;
				case "5": Input(btnText); break;
				case "6": Input(btnText); break;
				case "7": Input(btnText); break;
				case "8": Input(btnText); break;
				case "9": Input(btnText); break;
				case "0": Input(btnText); break;
				case ".": Input(btnText); break;
				case "Del": Operate(btnText); break;
				case "AC": Operate(btnText); break;
				case "×": Operate(btnText); prevSign = btnText; break;
				case "÷": Operate(btnText); prevSign = btnText; break;
				case "+": Operate(btnText); prevSign = btnText; break;
				case "-": Operate(btnText); prevSign = btnText; break;
				case "=": Operate(prevSign); break;
				default: break;
			}
		}
		public void Operate(string operatorSign)
        {
			try
            {
				if (operatorSign == "AC" || operatorSign == "Del")
                {
					switch (operatorSign)
                    {
						case "AC":
							RightOperand.Text = null;
							LeftOperand.Text = null;
							break;
						case "Del":
							if (RightOperand.Text.Length != 0)
							{
								RightOperand.Text = RightOperand.Text.Remove(RightOperand.Text.Length - 1);
							}
							break;
					}
                }else
                {
					if (LeftOperand.Text.Length == 0 && RightOperand.Text.Length != 0)
					{
						LeftOperand.Text = RightOperand.Text;
						RightOperand.Text = null;
					}
					else if (RightOperand.Text.Length != 0 && LeftOperand.Text.Length != 0)
					{
						switch (operatorSign)
						{
							case "×":
								LeftOperand.Text = Convert.ToString(Convert.ToDecimal(RightOperand.Text) * Convert.ToDecimal(LeftOperand.Text));
								RightOperand.Text = null;
								break;
							case "÷":
								LeftOperand.Text = Convert.ToString(Convert.ToDecimal(LeftOperand.Text) / Convert.ToDecimal(RightOperand.Text));
								RightOperand.Text = null;
								break;
							case "+":
								LeftOperand.Text = Convert.ToString(Convert.ToDecimal(RightOperand.Text) + Convert.ToDecimal(LeftOperand.Text));
								RightOperand.Text = null;
								break;
							case "-":
								LeftOperand.Text = Convert.ToString(Convert.ToDecimal(LeftOperand.Text) - Convert.ToDecimal(RightOperand.Text));
								RightOperand.Text = null;
								break;
						}
					}
				}
				
			}catch (DivideByZeroException)
            {
				MessageBox.Show("The application cannot divide number by zero.");
            }catch (Exception ex)
            {
				MessageBox.Show(ex.ToString());
            }
		}
		public void Input(string btnCase)
        {
			RightOperand.Text += btnCase;
        }
        public IEnumerable<Control> GetButtons(Control control, Type type)
		{
			var controls = control.Controls.Cast<Control>();

			return controls.SelectMany(ctrl => GetButtons(ctrl, type))
									  .Concat(controls)
									  .Where(c => c.GetType() == type);
		}
	}
}