using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Transactions : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public Transactions()
        {
            InitializeComponent();

            // Populate the customer and product ComboBoxes on form load
            PopulateCustomerDropdown();
            PopulateProductDropdown();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill_Data BillPage = new Bill_Data();
            BillPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int transaction_ID = int.Parse(textBox1.Text);
            DateTime transactionDate = DateTime.Now;
            int productID = ((ProductItem)comboBox2.SelectedItem).product_ID;
            int customerID = ((CustomerItem)comboBox1.SelectedItem).customer_ID;

            int quantity = int.Parse(textBox3.Text);
            //DateTime transactionDate = DateTime.Now;
            decimal price = decimal.Parse(textBox5.Text);

            if (quantity <= 0 || price <= 0)
            {
                MessageBox.Show("Please fill in valid Quantity and Price.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertTransactionsData", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Transaction_ID", transaction_ID);
                        cmd.Parameters.AddWithValue("@Customer_ID", customerID);
                        cmd.Parameters.AddWithValue("@Product_ID", productID);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Transaction_Date", transactionDate);
                        cmd.Parameters.AddWithValue("@Price", price);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Transaction data added successfully!");

                // Clear the input fields after insertion
                textBox1.Text = "";
                textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateCustomerDropdown()
        {
            comboBox1.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Customer_ID FROM CUSTOMER", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customer_ID = reader.GetInt32(0);
                            comboBox1.Items.Add(new CustomerItem(customer_ID));
                        }
                    }
                }
            }
        }

        private void PopulateProductDropdown()
        {
            comboBox2.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Product_ID FROM PRODUCTS", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int product_ID = reader.GetInt32(0);
                            comboBox2.Items.Add(new ProductItem(product_ID));
                        }
                    }
                }
            }
        }

        internal class CustomerItem
        {
            public int customer_ID { get; set; }

            public CustomerItem(int customer_ID)
            {
                this.customer_ID = customer_ID;
            }
        }

        internal class ProductItem
        {
            public int product_ID { get; set; }

            public ProductItem(int product_ID)
            {
                this.product_ID = product_ID;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage();
            homePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTransactionData();
        }
        private void DisplayTransactionData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM TRANSACTION_DATA";

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = (DataTable)dataGridView1.DataSource;

                            workbook.Worksheets.Add(dt, "TRANSACTION_DATA");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have successfully exported your data to an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
