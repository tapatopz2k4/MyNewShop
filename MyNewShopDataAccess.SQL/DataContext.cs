using MyNewShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewShopDataAccess.SQL
{
    public class DataContext : DbContext
    {
        //The (base) below allows us to pass in the Connection String sname information.
        public DataContext()
            : base("EFTestDB_dev") {

        }


        //These declarations with (DbSet) specifies for EF which models will be storing tables in the Database.
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories {get; set; }



    }
}
