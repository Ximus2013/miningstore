using Microsoft.AspNetCore.Mvc;
using miningstore.Data.Interfaces;
using miningstore.Data.Models;
using miningstore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IAllCategories _allCategories;
        public ProductsController(IAllProducts iAllProducts, IAllCategories iAllCategories) 
            { 
            _allProducts = iAllProducts;
            _allCategories = iAllCategories;
            }



        [Route("Product/List")]
        [Route("Product/List{category}")]
        public ViewResult List(string category)
        {
            string _category =  category;
            IEnumerable<Product> product = null;
            string productCategory = "";
            if (string.IsNullOrEmpty(category))
                {
                product = _allProducts.AllProducts.OrderBy(i => i.id);
                }
            else
            {
                if (string.Equals("cpu", category, StringComparison.OrdinalIgnoreCase))
                {
                    product = _allProducts.AllProducts.Where(i => i.Category.CategoryName.Equals("Процессоры")).OrderBy(i => i.id);
                }
                else if (string.Equals("gpu", category, StringComparison.OrdinalIgnoreCase))
                {
                    product = _allProducts.AllProducts.Where(i => i.Category.CategoryName.Equals("Видеокарты")).OrderBy(i => i.id);
                }

                productCategory = _category;

            }

            var prodObj = new ProductListViewModel
            {
                allProducts = product,
                productCategory = productCategory
            };

            return View(prodObj);

        }
    }
}
