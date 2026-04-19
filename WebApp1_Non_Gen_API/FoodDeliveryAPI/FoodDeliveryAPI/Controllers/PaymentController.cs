using Microsoft.AspNetCore.Mvc;
using FoodDeliveryAPI.Services.Interfaces;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _service;

        public PaymentController(IPaymentService service)
        {
            _service = service;
        }

        // GET ALL
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET BY ID
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetById(id));
        }

        // CREATE
        [HttpPost]
        public IActionResult Create(Payment payment)
        {
            _service.Add(payment);
            return Ok("Payment Added");
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult Update(int id, Payment payment)
        {
            _service.Update(id, payment);
            return Ok("Payment Updated");
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok("Payment Deleted");
        }
    }
}