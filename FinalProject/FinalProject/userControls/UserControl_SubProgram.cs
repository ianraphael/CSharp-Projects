using System;
using System.Data;
using System.Data.SqlClient;
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
    public partial class UserControl_SubProgram : UserControl
    {
        public UserControl_SubProgram()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=FinalProject;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Items values (@ItemNumber, @Name, @Quantity, @Price)", con);
                cmd.Parameters.AddWithValue("@ItemNumber", int.Parse(ItemNumberCont.Text));
                cmd.Parameters.AddWithValue("@Name", NameCont.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(QuantityCont.Text));
                cmd.Parameters.AddWithValue("@Price", int.Parse(PriceCont.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show($"{NameCont.Text} is added.");
            }
            catch
            {
                MessageBox.Show("Please make sure you entered right inputs");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=FinalProject;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Update Items set Name = @Name, Quantity = @Quantity, Price = @Price where ItemNumber = @ItemNumber", con);
                cmd.Parameters.AddWithValue("@ItemNumber", int.Parse(ItemNumberCont.Text));
                cmd.Parameters.AddWithValue("@Name", NameCont.Text);
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(QuantityCont.Text));
                cmd.Parameters.AddWithValue("@Price", int.Parse(PriceCont.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Item with Item Number {ItemNumberCont.Text} is updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Make sure that the Item Number is present in your shop.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=FinalProject;Integrated Security=True");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Delete Items where ItemNumber = @ItemNumber", con);
                cmd.Parameters.AddWithValue("@ItemNumber", int.Parse(ItemNumberCont.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show($"user with id {ItemNumberCont.Text} has been deleted.");
            }
            catch
            {
                MessageBox.Show("Please make sure you entered right inputs");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KH50ICJB;Initial Catalog=FinalProject;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Items", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
