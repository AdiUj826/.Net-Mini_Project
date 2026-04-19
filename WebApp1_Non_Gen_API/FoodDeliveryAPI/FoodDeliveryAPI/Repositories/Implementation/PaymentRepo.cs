using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryAPI.Repositories.Implementation
{
    public class PaymentRepo : IPaymentRepo
    {
        private static List<Payment> payments = new List<Payment>()
        {
            new Payment { Id = 1, Amount = 500 }
        };

        public List<Payment> GetAll()
        {
            return payments;
        }

        public Payment GetById(int id)
        {
            return payments.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Payment payment)
        {
            payment.Id = payments.Count + 1;
            payments.Add(payment);
        }

        public void Update(int id, Payment payment)
        {
            var existing = payments.FirstOrDefault(x => x.Id == id);
            if (existing != null)
            {
                existing.Amount = payment.Amount;
            }
        }

        public void Delete(int id)
        {
            var data = payments.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                payments.Remove(data);
            }
        }
    }
}