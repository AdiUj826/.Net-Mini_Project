namespace FoodDeliveryAPI.Services.Interfaces
{
    using FoodDeliveryAPI.Models;
    public interface IPaymentService
    {
        List<Payment> GetAll();
        Payment GetById(int id);
        void Add(Payment payment);
        void Update(int id, Payment payment);
        void Delete(int id);
    }
}