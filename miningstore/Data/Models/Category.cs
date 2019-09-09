using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string CategoryName { set; get; }
        public string DescCategory { set; get; }
        public List<Product> Product { set; get; }

    }
}
