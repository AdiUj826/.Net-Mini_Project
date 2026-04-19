using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Repositories.Interfaces
{
    public interface IDeliveryRepo
    {
        List<Delivery> GetAll();
        Delivery GetById(int id);
        void Add(Delivery delivery);
        void Update(int id, Delivery delivery);
        void Delete(int id);
    }
}