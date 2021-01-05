using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
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

        public ViewResult CarList()
        {
            ViewBag.Title = "Cars List";

            CarListModel carList = new CarListModel();
            carList.AllCars = _getCars.GetAllCars;
            carList.CurrentCategory = "Automobiles";

            return View(carList);
        }
    }
}
