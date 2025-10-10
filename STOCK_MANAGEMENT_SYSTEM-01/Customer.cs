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

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Customer : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public Customer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(textBox1.Text);
            string customerName = textBox2.Text;
            string address = textBox3.Text;
            string email = textBox4.Text;
            string mobilePhone = textBox5.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobilePhone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertCustomer", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Customer_ID", customerID);
                        cmd.Parameters.AddWithValue("@Customer_name", customerName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Mobile_phone", mobilePhone);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer added successfully!");

                // Clear the input fields after insertion
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayCustomerData();
        }

        private void DisplayCustomerData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM CUSTOMER";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_dashboard adminPage = new Admin_dashboard();
            adminPage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}