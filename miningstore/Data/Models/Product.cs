using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.Models
{
    public class Product
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string ShortDesc { set; get; }
        public string LongDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isfavorite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }

    }
}
