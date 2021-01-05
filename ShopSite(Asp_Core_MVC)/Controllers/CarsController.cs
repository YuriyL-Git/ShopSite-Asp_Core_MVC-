using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;

namespace ShopSite_Asp_Core_MVC_.Controllers
{
    public class CarsController : Controller
    {
        private readonly IGetCars _getCars;
        private readonly ICarsCategory _allCarsCategories;

        public CarsController(IGetCars getCars, ICarsCategory allCarsCategories)
        {
            _getCars = getCars;
            _allCarsCategories = allCarsCategories;
        }

        public ViewResult CarList()
        {
            ViewBag.Category = "Some New";

            var allCarsList = _getCars.GetAllCars;

            return View(allCarsList);
        }
    }
}
