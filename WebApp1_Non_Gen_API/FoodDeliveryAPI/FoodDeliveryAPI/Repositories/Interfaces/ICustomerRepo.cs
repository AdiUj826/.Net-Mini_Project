using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Repositories.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void Add(Customer customer);
        void Update(int id, Customer customer);
        void Delete(int id);
    }
}