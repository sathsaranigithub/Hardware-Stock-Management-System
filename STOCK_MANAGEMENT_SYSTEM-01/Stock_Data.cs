using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Stock_Data : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public Stock_Data()
        {
            InitializeComponent();

            // Populate the product dropdown on form load
            PopulateProductDropdown();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viewdata_Supplier viewPage = new Viewdata_Supplier();
            viewPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int stockID = int.Parse(textBox1.Text);
            int productID = ((ProductItem)comboBox1.SelectedItem).product_ID; // Get the selected product ID from ComboBox
            int quantity = int.Parse(textBox3.Text);

            if (productID <= 0 || quantity <= 0)
            {
                MessageBox.Show("Please fill in a valid Product ID and Quantity.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertStockData", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Stock_ID", stockID);
                        cmd.Parameters.AddWithValue("@Product_ID", productID);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Stock data added successfully!");

                // Clear the input fields after insertion
                textBox1.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateProductDropdown()
        {
            comboBox1.Items.Clear();
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
                            comboBox1.Items.Add(new ProductItem(product_ID));
                        }
                    }
                }
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
            Supplier_dashboard supplierPage = new Supplier_dashboard();
            supplierPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayStockData();
        }

        private void DisplayStockData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM STOCK_DATA";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to a new DataGridView (e.g., dataGridView2)
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

                            workbook.Worksheets.Add(dt, "STOCK_DATA");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
