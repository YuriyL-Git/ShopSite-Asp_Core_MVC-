using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSite_Asp_Core_MVC_.Data.Models
{
    public class CarCaterory
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public List<Car> CarsList { get; set; }

    }
}
