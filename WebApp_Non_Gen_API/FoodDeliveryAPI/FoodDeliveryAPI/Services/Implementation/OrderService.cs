using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using FoodDeliveryAPI.Services.Interfaces;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _repo;

        public OrderService(IOrderRepo repo)
        {
            _repo = repo;
        }

        public List<Order> GetAll() => _repo.GetAll();
        public Order GetById(int id) => _repo.GetById(id);
        public void Add(Order order) => _repo.Add(order);
        public void Update(int id, Order order) => _repo.Update(id, order);
        public void Delete(int id) => _repo.Delete(id);
    }
}