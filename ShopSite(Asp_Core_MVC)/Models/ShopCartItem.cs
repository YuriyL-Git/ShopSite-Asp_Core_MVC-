using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }

        public Car car { get; set; }

        public int Price { get; set; }

        public string ShopCartId { get; set; }


    }
}
