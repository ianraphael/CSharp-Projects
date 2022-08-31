using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=SimpleCrud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into userTable values (@ID, @Name, @Age)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery(); MessageBox.Show($"{textBox2.Text} is added.");

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=SimpleCrud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update userTable set Name = @Name, Age = @Age where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery(); MessageBox.Show($"user with id {textBox1.Text} is updated.");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=SimpleCrud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete userTable where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show($"user with id {textBox1.Text} has been deleted.");
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=SimpleCrud;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from userTable", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
