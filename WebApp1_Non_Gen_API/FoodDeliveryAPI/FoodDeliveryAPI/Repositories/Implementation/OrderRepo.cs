using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryAPI.Repositories.Implementation
{
    public class OrderRepo : IOrderRepo
    {
        private static List<Order> orders = new List<Order>()
        {
            new Order { Id = 1, CustomerId = 1 }
        };

        public List<Order> GetAll() => orders;

        public Order GetById(int id) => orders.FirstOrDefault(x => x.Id == id);

        public void Add(Order order)
        {
            order.Id = orders.Count + 1;
            orders.Add(order);
        }

        public void Update(int id, Order order)
        {
            var data = orders.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                data.CustomerId = order.CustomerId;
            }
        }

        public void Delete(int id)
        {
            var data = orders.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                orders.Remove(data);
            }
        }
    }
}