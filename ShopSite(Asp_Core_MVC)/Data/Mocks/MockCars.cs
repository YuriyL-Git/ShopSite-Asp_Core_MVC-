using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Data.Mocks
{
    public class MockCars : IGetCars
    {
        private readonly ICarsCategory _categoryCars = new MockCarsCategory();

        public IEnumerable<Car> GetAllCars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla",
                        ShortDecsription = "Fast automobile",
                        LongDescription  = "Beautiful, fast and very quiet automobile",
                        Image = "https://www.pngkey.com/png/full/802-8024110_attractions-link-tourism-services-m-toyota-corolla-s.png",
                        Price = 45000, IsFavorite = true, 
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDecsription = "Calm and quiet",
                        LongDescription  = "Convenient automobile for city life",
                        Image = "https://www.pngkey.com/png/full/120-1209183_2018-ford-fiesta-in-hot-pepper-red-metallic.png",
                        Price = 11000, IsFavorite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },

                    new Car
                    {
                        Name = "BMW M3",
                        ShortDecsription = "Stylish and powerful",
                        LongDescription  = "Powerful and convinient automobile",
                        Image = "https://www.pngkey.com/png/full/430-4307799_2018-bmw-m3-bmw-m3-2018-white.png",
                        Price = 65000, IsFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Mersedes C class",
                        ShortDecsription = "Big and comfortable",
                        LongDescription  = "Comfortable auto for city life",
                        Image = "https://img.mercedes-benz-kiev.com/data/purchase/c-class-coupe/0052600121/mercedes-benz-c-class-coupe-1.jpg",
                        Price = 40000, IsFavorite = false,
                        Available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Nissan leaf",
                        ShortDecsription = "Noiseless and economical ",
                        LongDescription  = "Noiseless and economical auto for city life",
                        Image = "https://www.pngkey.com/png/full/580-5800783_toyota-prius-nissan-leaf-s-2019.png",
                        Price = 14000, IsFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };

                
            }
           
        }
        public IEnumerable<Car> GetFavoriteCars { get; set; }
        public Car GetCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
