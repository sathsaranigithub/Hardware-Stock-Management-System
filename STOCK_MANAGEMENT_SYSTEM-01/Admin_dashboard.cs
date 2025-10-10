using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK_MANAGEMENT_SYSTEM_01
{
    public partial class Admin_dashboard : Form
    {
        public Admin_dashboard()
        {
            InitializeComponent();
        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer customerPage = new Customer();
            customerPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSupplier supplierPage = new AddSupplier();
            supplierPage.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewBilldatafor_Admin BILLPage = new ViewBilldatafor_Admin();
            BILLPage.Show();
            this.Hide();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            View_Products productPage = new View_Products();
            productPage.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Supplier_dashboard productPage = new Supplier_dashboard();
            productPage.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
