using Microsoft.EntityFrameworkCore;
using miningstore.Data.Interfaces;
using miningstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDBContent;
        public ProductRepository(AppDBContent appDBContent)
            {
            this.appDBContent = appDBContent;
            }



        public IEnumerable<Product> AllProducts => appDBContent.Product.Include(c => c.Category);

        public IEnumerable<Product> GetFavoriteProduct => appDBContent.Product.Where(p => p.isfavorite).Include(c => c.Category);

        public Product GetProductID(int ProductID) => appDBContent.Product.FirstOrDefault(p => p.id == ProductID);

    }
}
