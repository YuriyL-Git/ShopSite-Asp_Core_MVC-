using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopSite_Asp_Core_MVC_.Data.Repository
{
    public class CarCategoryRepository : IAllCars
    {
        private readonly AppDBContent _appDbContent;

        public CarCategoryRepository(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Car> GetAllCarsByCategory => _appDbContent.Car.Include(c => c.Category);
        public IEnumerable<Car> GetFavoriteCars => _appDbContent.Car.Where(p => p.IsFavorite).Include(c => c.Category);
        public Car GetCar(int carId) => _appDbContent.Car.FirstOrDefault(p => p.Id == carId);

    }
}
