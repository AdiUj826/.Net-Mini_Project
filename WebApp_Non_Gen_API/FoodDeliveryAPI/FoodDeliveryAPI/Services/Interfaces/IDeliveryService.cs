using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Services.Interfaces
{
    public interface IDeliveryService
    {
        List<Delivery> GetAll();
        Delivery GetById(int id);
        void Add(Delivery delivery);
        void Update(int id, Delivery delivery);
        void Delete(int id);
    }
}