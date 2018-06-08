using MyNewShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewShop.Core.ViewModels
{
    public class ProductListViewModel
    {

        public IEnumerable<Product> Products { set; get; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }

    }
}
