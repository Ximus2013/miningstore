using miningstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.Interfaces
{
   public interface IAllProducts
    {
        IEnumerable<Product> AllProducts { get;}
        IEnumerable<Product> GetFavoriteProduct { get;}
        Product GetProductID  (int ProductID); 
    }
}
