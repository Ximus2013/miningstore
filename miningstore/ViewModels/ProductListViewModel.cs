using miningstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> allProducts { get; set; }
        public string productCategory { get; set; }

    }
}
