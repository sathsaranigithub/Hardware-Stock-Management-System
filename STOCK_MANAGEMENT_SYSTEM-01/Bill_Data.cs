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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Bill_Data : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public Bill_Data()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transactions transPage = new Transactions();
            transPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Handle adding bill data
            AddBillData();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Handle viewing bill data
            ViewBillData();
        }
        // Method to add bill data
        private void AddBillData()
        {
            // Implement code to add bill data to the database
            // Retrieve data from the form's UI elements (e.g., textboxes)


            int customerID = int.Parse(textBox1.Text);
            int billID = int.Parse(textBox3.Text);
            DateTime transactionDate = DateTime.Parse(dateTimePicker1.Text);
            decimal totalValue = decimal.Parse(textBox2.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertBillDatas", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Customer_ID", customerID);
                        cmd.Parameters.AddWithValue("@Bill_ID", billID); // Update to Bill_ID
                        cmd.Parameters.AddWithValue("@Transaction_Date", transactionDate);
                        cmd.Parameters.AddWithValue("@Total_value", totalValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Bill data added successfully!");
                // Clear the input fields after insertion
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Method to view bill data
        private void ViewBillData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM BILL_DATA";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to a DataGridView (e.g., dataGridView1)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}




