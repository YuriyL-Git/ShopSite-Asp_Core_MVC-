using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Models
{
    public class CarListModel
    {
        public IEnumerable<Car> AllCars { get; set; } 

        public string CurrentCategory { get; set; }
    }
}
