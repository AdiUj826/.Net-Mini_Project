using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using FoodDeliveryAPI.Services.Interfaces;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepo _repo;

    public PaymentService(IPaymentRepo repo)
    {
        _repo = repo;
    }

    public List<Payment> GetAll() => _repo.GetAll();
    public Payment GetById(int id) => _repo.GetById(id);
    public void Add(Payment payment) => _repo.Add(payment);
    public void Update(int id, Payment payment) => _repo.Update(id, payment);
    public void Delete(int id) => _repo.Delete(id);
}