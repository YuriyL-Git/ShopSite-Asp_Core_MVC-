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
        //Populating the database with initial values from Mock objects
        public static void Initial(AppDBContent dbContent)
        {
            var listOfCars = new MockCars().GetAllCars;
            var listCategories = new MockCarsCategory().AllCategories;

            if (!dbContent.CarCaterory.Any())
                {
                    foreach (var cat in listCategories)
                    {

                        dbContent.CarCaterory.Add(cat);
                    }

                }

                if (!dbContent.Car.Any())
                {
                    foreach (var car in listOfCars)
                    {

                        dbContent.Car.Add(car);
                    }

                }

                dbContent.SaveChanges();

        }

        
    }
}
