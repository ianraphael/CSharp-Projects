using System;
using System.Drawing;
using System.Windows.Forms;




/* 
    Note: Be sure to change the server name if you want to run this on your machine. Also make an update for your System.Data.SqlClient to make the system run properly. Thank you.
    Members: 
        Ian Labicnai
        Efren Gorospe
        Arnold Fernando
        Jr Carbonel
*/


namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutToolStripMenuItem.BackColor = Color.LightGray;
            subprogramToolStripMenuItem.BackColor = Color.White;
            userControl_About1.Visible = true;
            userControl_SubProgram1.Visible = false;
        }

        private void subprogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subprogramToolStripMenuItem.BackColor = Color.LightGray;
            aboutToolStripMenuItem.BackColor = Color.White;
            userControl_About1.Visible = false;
            userControl_SubProgram1.Visible = true;
        }
    }
}
