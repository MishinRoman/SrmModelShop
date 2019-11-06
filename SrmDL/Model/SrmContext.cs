using SrmBL.Model;
using System.Data.Entity;

namespace SrmBL.Model
{
    public class SrmContext : DbContext
    {
        public SrmContext() : base("SrmConnection") { }


        public DbSet<Check> Checks { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sell> Sells { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        

    }
}
