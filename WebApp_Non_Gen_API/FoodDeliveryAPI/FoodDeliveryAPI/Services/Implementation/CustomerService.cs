using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using FoodDeliveryAPI.Services.Interfaces;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _repo;

        public CustomerService(ICustomerRepo repo)
        {
            _repo = repo;
        }

        public List<Customer> GetAll() => _repo.GetAll();
        public Customer GetById(int id) => _repo.GetById(id);
        public void Add(Customer customer) => _repo.Add(customer);
        public void Update(int id, Customer customer) => _repo.Update(id, customer);
        public void Delete(int id) => _repo.Delete(id);
    }
}