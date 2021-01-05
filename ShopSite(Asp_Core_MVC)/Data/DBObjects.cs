using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ShopSite_Asp_Core_MVC_.Data.Mocks;
using ShopSite_Asp_Core_MVC_.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopSite_Asp_Core_MVC_.Data
{
    public class DBObjects
    {
        public static void Initial(IApplicationBuilder app)
        {
            AppDBContent dbContent = app.ApplicationServices.GetRequiredService<AppDBContent>();

            if (!dbContent.CarCaterory.Any())
            {
                dbContent.CarCaterory.AddRange(Categories.Select(c => c.Value));
            }
        }

        private static Dictionary<string, CarCategory> category;

        public static Dictionary<string, CarCategory> Categories
        {
            get
            {
                if (category == null)
                {
                    var listCategories = new MockCarsCategory().AllCategories;


                    category = new Dictionary<string, CarCategory>();

                    foreach (var cat in listCategories)
                    {
                        category.Add(cat.CategoryName, cat);
                    }
                }

                return category;
            }
        }
    }
}
