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
using ClosedXML.Excel;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class ViewBilldatafor_Admin : Form
    {

        private const string ConnectionString = "Data Source=NIMESH; Initial Catalog = Hardware_stock_management_system; Integrated Security=True;";

        public ViewBilldatafor_Admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_dashboard AdminPage = new Admin_dashboard();
            AdminPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBillData02();
        }
        private void ViewBillData02()
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

        private void button3_Click(object sender, EventArgs e)
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
                            workbook.Worksheets.Add(dt, "BILL_DATA");
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




