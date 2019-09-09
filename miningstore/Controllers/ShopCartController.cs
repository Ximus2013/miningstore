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
    public class ShopCartController : Controller
    {
        private readonly IAllProducts _prodRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllProducts prodRep, ShopCart shopCart)
        {
            _prodRep = prodRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _prodRep.AllProducts.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
