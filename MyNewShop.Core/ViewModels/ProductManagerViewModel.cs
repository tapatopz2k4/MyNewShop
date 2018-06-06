using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNewShop.Core.Models;

namespace MyNewShop.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { set; get; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }

    }
}
