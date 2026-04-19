using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using FoodDeliveryAPI.Services.Interfaces;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Services.Implementation
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepo _repo;

        public DeliveryService(IDeliveryRepo repo)
        {
            _repo = repo;
        }

        public List<Delivery> GetAll() => _repo.GetAll();
        public Delivery GetById(int id) => _repo.GetById(id);
        public void Add(Delivery delivery) => _repo.Add(delivery);
        public void Update(int id, Delivery delivery) => _repo.Update(id, delivery);
        public void Delete(int id) => _repo.Delete(id);
    }
}