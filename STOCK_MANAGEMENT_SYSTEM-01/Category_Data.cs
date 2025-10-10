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
    public partial class Category_Data : Form
    {

        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";


        public Category_Data()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products_data productPage = new Products_data();
            productPage.Show();
            this.Hide();
        }

        private void Category_Data_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string categoryName = textBox2.Text;
            string categoryDescription = richTextBox1.Text;

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please fill in the Category Name.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertCategory", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Category_name", categoryName);
                        cmd.Parameters.AddWithValue("@Category_description", categoryDescription);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Category added successfully!");

                // Clear the input fields after insertion
                textBox2.Text = "";
                richTextBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayCategoryData();
        }

        private void DisplayCategoryData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM CATEGORIES";

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

        private void button4_Click(object sender, EventArgs e)
        {

            Products_data productdataPage = new Products_data();
            productdataPage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}