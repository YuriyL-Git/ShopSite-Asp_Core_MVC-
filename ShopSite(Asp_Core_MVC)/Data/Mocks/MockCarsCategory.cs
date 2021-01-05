using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Data.Mocks
{
    public class MockCarsCategory : ICarsCategory
    {
        public IEnumerable<CarCaterory> AllCategories
        {
            get
            {
                return new List<CarCaterory>
                {
                    new CarCaterory {CategoryName = "Electromobiles", Description = "Modern type of venicles "},
                    new CarCaterory {CategoryName = "Classic automobiles", Description = "Bensine cars"},

                };

            }
        }
    }
}
 