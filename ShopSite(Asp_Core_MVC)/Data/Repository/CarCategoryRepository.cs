using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopSite_Asp_Core_MVC_.Data.Repository
{
    public class CarCategoryRepository : ICarsCategory
    {
        private readonly AppDBContent _appDbContent;

        public CarCategoryRepository(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<CarCategory> AllCategories => _appDbContent.CarCaterory;


    }
}
