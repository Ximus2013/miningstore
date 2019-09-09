using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace miningstore.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string ShopCartID { get; set; }
        public List <ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartID = session.GetString("CartID") ?? Guid.NewGuid().ToString();

            session.SetString("CartID", shopCartID);

            return new ShopCart(context) { ShopCartID = shopCartID };
        }

        public void AddToCart(Product product)
        {
           appDBContent.ShopCartItem.Add(new ShopCartItem{

                ShopCartID = ShopCartID,
                product = product,
               price = product.price
           });
            appDBContent.SaveChanges();
        }



        public List<ShopCartItem> getShopItems()
        {

            return appDBContent.ShopCartItem.Where(c => c.ShopCartID == ShopCartID).Include(s => s.product).ToList();

        }
    }
}
