using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ToDoInput.Text.Length > 2)
            {
                ToDoList.Items.Add(ToDoInput.Text);
                ToDoInput.Text = null;
            }
            else
                MessageBox.Show("Please make sure to add a todo.");
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ToDoList.Items.Remove(ToDoList.SelectedItem.ToString());
            }catch
            {
                MessageBox.Show("Please make sure that you have an item to remove. :)");
            }
        }
    }
}
