﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSite_Asp_Core_MVC_.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDecsription { get; set; }

        public string LongDescription { get; set; }

        public string Image { get; set; }

        public ushort Price { get; set; }

        public bool IsFavorite { get; set; }

        //quantity of item on storage
        public bool Available { get; set; }

        public int CategoryId { get; set; }

        public virtual CarCaterory Category { set; get; }
    }
}
