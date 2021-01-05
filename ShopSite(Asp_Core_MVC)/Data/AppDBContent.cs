using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<CarCategory> CarCaterory { get; set; }
    }
}
