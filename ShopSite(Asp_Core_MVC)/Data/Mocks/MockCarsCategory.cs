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
        public IEnumerable<CarCategory> AllCategories
        {
            get
            {
                return new List<CarCategory>
                {
                    new CarCategory {CategoryName = "Electromobiles", Description = "Modern type of venicles "},
                    new CarCategory {CategoryName = "Classic automobiles", Description = "Bensine cars"},
                    new CarCategory {CategoryName = "Retro automobiles", Description = "Old Automobiles"}

                };

            }
        }
    }
}
 