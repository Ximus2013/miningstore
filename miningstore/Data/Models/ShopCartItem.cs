using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.Models
{
    public class ShopCartItem
    {
        public int ID { get; set; }
        public Product product { get; set; }
        public int price { get; set; }

        public string ShopCartID { get; set; }
    }
}
