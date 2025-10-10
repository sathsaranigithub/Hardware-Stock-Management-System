using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Products_data : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public Products_data()
        {
            InitializeComponent();

            // Populate the supplier and category dropdowns on form load
            PopulateSupplierDropdown();
            PopulateCategoryDropdown();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category_Data categoryPage = new Category_Data();
            categoryPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock_Data stockPage = new Stock_Data();
            stockPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(textBox1.Text);
            string productName = textBox2.Text;
            string productDescription = textBox8.Text;
            decimal productPrice = decimal.Parse(textBox3.Text);
            string unitQuantity = textBox7.Text;
            int stockUnits = int.Parse(textBox6.Text);

            // Get the selected supplier and category IDs from ComboBox
            int supplierID = ((SupplierItem)comboBox2.SelectedItem).supplier_ID;
            int categoryID = ((CategoryItem)comboBox1.SelectedItem).category_ID;

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please fill in the Product Name.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertProductss", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Supplier_ID", supplierID);
                        cmd.Parameters.AddWithValue("@Category_ID", categoryID);
                        cmd.Parameters.AddWithValue("@Product_name", productName);
                        cmd.Parameters.AddWithValue("@Product_description", productDescription);
                        cmd.Parameters.AddWithValue("@Product_price", productPrice);
                        cmd.Parameters.AddWithValue("@Unit_Quantity", unitQuantity);
                        cmd.Parameters.AddWithValue("@Stock_units", stockUnits);
                        cmd.Parameters.AddWithValue("@Product_ID", productID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully!");

                // Clear the input fields after insertion
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PopulateSupplierDropdown()
        {
            comboBox2.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Supplier_ID FROM SUPPLIERS", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int supplier_ID = reader.GetInt32(0);
                            comboBox2.Items.Add(new SupplierItem(supplier_ID));
                        }
                    }
                }
            }
        }

        private void PopulateCategoryDropdown()
        {
            comboBox1.Items.Clear();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Category_ID FROM CATEGORIES", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int category_ID = reader.GetInt32(0);
                            comboBox1.Items.Add(new CategoryItem(category_ID));
                        }
                    }
                }
            }
        }

        internal class SupplierItem
        {
            public int supplier_ID { get; set; }

            public SupplierItem(int supplier_ID)
            {
                this.supplier_ID = supplier_ID;
            }
        }

        internal class CategoryItem
        {
            public int category_ID { get; set; }

            public CategoryItem(int category_ID)
            {
                this.category_ID = category_ID;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Supplier_dashboard supplierPage = new Supplier_dashboard();
            supplierPage.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Products_data_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
