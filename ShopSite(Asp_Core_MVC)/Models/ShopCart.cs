using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ShopSite_Asp_Core_MVC_.Data;

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

            string shopCartId = 
        }
    }
}
