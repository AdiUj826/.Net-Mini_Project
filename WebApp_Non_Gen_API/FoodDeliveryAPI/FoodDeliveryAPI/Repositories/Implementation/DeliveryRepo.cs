using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryAPI.Repositories.Implementation
{
    public class DeliveryRepo : IDeliveryRepo
    {
        private static List<Delivery> deliveries = new List<Delivery>()
        {
            new Delivery { Id = 1, Status = "Pending" }
        };

        public List<Delivery> GetAll() => deliveries;

        public Delivery GetById(int id) => deliveries.FirstOrDefault(x => x.Id == id);

        public void Add(Delivery delivery)
        {
            delivery.Id = deliveries.Count + 1;
            deliveries.Add(delivery);
        }

        public void Update(int id, Delivery delivery)
        {
            var data = deliveries.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                data.Status = delivery.Status;
            }
        }

        public void Delete(int id)
        {
            var data = deliveries.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                deliveries.Remove(data);
            }
        }
    }
}