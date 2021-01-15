using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ShopSite_Asp_Core_MVC_.Data;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Models
{
    public class ShopCart
    {
        private readonly AppDBContent _appDbContent;
        public ShopCart(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }


        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopCartItems { get; set; }




        public static ShopCart GetCart(IServiceProvider servises)
        {
            ISession session = servises.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = servises.GetService<AppDBContent>();

            //Create identifier of cart if absent
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", shopCartId);

            return new ShopCart(context) {ShopCartId = shopCartId};
        }



        public void AddToCart(Car carToAdd)
        {
            _appDbContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = carToAdd,
                Price = carToAdd.Price
            });
            _appDbContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return _appDbContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
