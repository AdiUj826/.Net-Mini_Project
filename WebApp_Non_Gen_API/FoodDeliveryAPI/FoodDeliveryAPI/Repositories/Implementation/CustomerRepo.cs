using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryAPI.Repositories.Implementation
{
    public class CustomerRepo : ICustomerRepo
    {
        private static List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Aditya" }
        };

        public List<Customer> GetAll() => customers;

        public Customer GetById(int id) => customers.FirstOrDefault(x => x.Id == id);

        public void Add(Customer customer)
        {
            customer.Id = customers.Count + 1;
            customers.Add(customer);
        }

        public void Update(int id, Customer customer)
        {
            var data = customers.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                data.Name = customer.Name;
            }
        }

        public void Delete(int id)
        {
            var data = customers.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                customers.Remove(data);
            }
        }
    }
}