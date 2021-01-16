using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopSite_Asp_Core_MVC_.Data.Interfaces;
using ShopSite_Asp_Core_MVC_.Models;

namespace ShopSite_Asp_Core_MVC_.Data.Repository
{
    public class OrdersRepository: IAllOrders
    {
        private readonly AppDBContent _appDbContent;
        private readonly ShopCart _shopCart;

        public OrdersRepository(AppDBContent appDbContent, ShopCart shopCart)
        {
            _shopCart = shopCart;
            _appDbContent = appDbContent;

        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDbContent.Orders.Add(order);

            var items = _shopCart.ListShopCartItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = item.car.Id,
                    OrderId = order.Id,
                    Price = item.car.Price
                     
                };

                _appDbContent.OrderDetails.Add(orderDetail);
            }

            _appDbContent.SaveChanges();

        }
    }
}
