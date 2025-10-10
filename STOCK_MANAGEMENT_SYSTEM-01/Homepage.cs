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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier_dashboard SupplierPage = new Supplier_dashboard();
            SupplierPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer_Dashboard customerPage = new Customer_Dashboard();
            customerPage.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
