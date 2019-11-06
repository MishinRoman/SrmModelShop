using SrmBL.Model;
using System;
using System.Windows.Forms;

namespace SrmUI
{
    public partial class Main : Form
    {
        SrmContext db;
        public Main()
        {
            InitializeComponent();
            db = new SrmContext();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

      

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var catalogProduct = new Catalog<Product>(db.Products);
            catalogProduct.Show();

        }
        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var catalogSeller = new Catalog<Seller>(db.Sellers);
            catalogSeller.Show();

        }
         private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var catalogCustomer = new Catalog<Customer>(db.Customers);
            catalogCustomer.Show();

        }
         private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var catalogCheck = new Catalog<Check>(db.Checks);
            catalogCheck.Show();

        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog()==DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            

        }
    }
}
