using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class AddSupplier : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public AddSupplier()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int supplierID = int.Parse(textBox1.Text); // Parse the Supplier_ID from the input

            string supplierName = textBox2.Text;
            string address = textBox3.Text;
            string company = textBox4.Text;
            string email = textBox5.Text;
            string mobilePhone = textBox6.Text;

            if (string.IsNullOrEmpty(supplierName) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mobilePhone))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("Insertsupplierss", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Supplier_ID", supplierID); // Add Supplier_ID

                        cmd.Parameters.AddWithValue("@Supplier_name", supplierName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Company", company);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Mobile_phone", mobilePhone);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Supplier added successfully!");

                // Clear the input fields after insertion
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplaySupplierData();
        }

        private void DisplaySupplierData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM SUPPLIERS";

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

        private void AddSupplier_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
