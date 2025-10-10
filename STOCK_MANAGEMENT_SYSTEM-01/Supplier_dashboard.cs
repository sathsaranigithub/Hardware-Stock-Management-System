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
    public partial class Supplier_dashboard : Form
    {
        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog=Hardware_stock_management_system;Integrated Security=True;";

        public Supplier_dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stock_Data stockPage = new Stock_Data();
            stockPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Products_data productPage = new Products_data();
            productPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transactions TransactionPage = new Transactions();
            TransactionPage.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage homePage = new Homepage();
            homePage.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
