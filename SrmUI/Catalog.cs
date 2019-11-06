using System.Data.Entity;
using System.Windows.Forms;

namespace SrmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {


        public Catalog(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView1.DataSource = set.Local.ToBindingList();
        }
    }
}
