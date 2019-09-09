using Microsoft.AspNetCore.Mvc;
using miningstore.Data.Interfaces;
using miningstore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miningstore.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAllProducts _allProducts;

        public HomeController(IAllProducts iAllProducts)
        {
            _allProducts = iAllProducts;

        }

        public ViewResult Index()
        {
            var homeProduct = new HomeViewModels
            {
                favProducts = _allProducts.GetFavoriteProduct
            };
            return View(homeProduct);
        }
    }
}
