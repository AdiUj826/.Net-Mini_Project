using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Repositories.Interfaces
{
    public interface IPaymentRepo
    {
        List<Payment> GetAll();
        Payment GetById(int id);
        void Add(Payment payment);
        void Update(int id, Payment payment);
        void Delete(int id);
    }
}