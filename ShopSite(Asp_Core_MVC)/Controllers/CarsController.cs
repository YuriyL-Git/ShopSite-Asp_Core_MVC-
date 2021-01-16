using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Data.Models;
using ShopSite_Asp_Core_MVC_.Models;

namespace ShopSite_Asp_Core_MVC_.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _getCars;
        private readonly ICarsCategory _allCarsCategories;

        public CarsController(IAllCars getCars, ICarsCategory allCarsCategories)
        {
            _getCars = getCars;
            _allCarsCategories = allCarsCategories;
        }

        [Route("Cars/carlist")]
        [Route("Cars/carlist/{category}")]
        public ViewResult CarList(string category, int id)
        {
            string _category = category;
            IEnumerable<Car> cars = null ;
            string currentCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _getCars.GetAllCars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _getCars.GetAllCars.Where(i => i.Category.CategoryName == "Electromobiles");
                }
                else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _getCars.GetAllCars.Where(i => i.Category.CategoryName == "Classic automobiles");
                }
                else if (string.Equals("retro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _getCars.GetAllCars.Where(i => i.Category.CategoryName == "Retro automobiles"); 
                }

                currentCategory = _category;
               
            }
            var car = new CarListModel
            {
                AllCars = cars,
                CurrentCategory = currentCategory
            };
            ViewBag.Title = "Cars List";
         

            return View(car);
        }
    }
}
