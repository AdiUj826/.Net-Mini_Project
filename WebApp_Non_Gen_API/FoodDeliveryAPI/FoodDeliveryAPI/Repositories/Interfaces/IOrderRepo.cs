using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Repositories.Interfaces
{
    public interface IOrderRepo
    {
        List<Order> GetAll();
        Order GetById(int id);
        void Add(Order order);
        void Update(int id, Order order);
        void Delete(int id);
    }
}