using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Models;

namespace ShopSite_Asp_Core_MVC_.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<CarCategory> AllCategories { get; }
    }
}
