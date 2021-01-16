using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSite_Asp_Core_MVC_.Models
{
    public class Order
    {
        public int  Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
