using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Models;

namespace ShopSite_Asp_Core_MVC_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRepository;
        private readonly ShopCart _shopCart;

        public HomeController(IAllCars carRepository, ShopCart shopCart)
        {
            _carRepository = carRepository;
            _shopCart = shopCart;

        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel();

            homeCars.favCars = _carRepository.GetFavoriteCars;
            
            return View(homeCars);
        }

        
    }
}
