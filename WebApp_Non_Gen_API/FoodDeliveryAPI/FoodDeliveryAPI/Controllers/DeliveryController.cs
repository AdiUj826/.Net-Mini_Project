using Microsoft.AspNetCore.Mvc;
using FoodDeliveryAPI.Services.Interfaces;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryService _service;

        public DeliveryController(IDeliveryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_service.GetById(id));

        [HttpPost]
        public IActionResult Create(Delivery delivery)
        {
            _service.Add(delivery);
            return Ok("Delivery Added");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Delivery delivery)
        {
            _service.Update(id, delivery);
            return Ok("Delivery Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok("Delivery Deleted");
        }
    }
}