using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Data.Repository;
using ShopSite_Asp_Core_MVC_.Models;

namespace ShopSite_Asp_Core_MVC_.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRepository, ShopCart shopCart)
        {
            _carRepository = carRepository;
            _shopCart = shopCart;

        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopCartItems = items;

            var shopCartModel = new ShopCartModel
            {
                ShopCart = _shopCart
            };

            return View(shopCartModel);

        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _carRepository.GetAllCars.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }


    }
}
