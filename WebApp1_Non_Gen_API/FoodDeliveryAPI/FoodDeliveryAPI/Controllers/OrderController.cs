using Microsoft.AspNetCore.Mvc;
using FoodDeliveryAPI.Services.Interfaces;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_service.GetById(id));

        [HttpPost]
        public IActionResult Create(Order order)
        {
            _service.Add(order);
            return Ok("Order Added");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Order order)
        {
            _service.Update(id, order);
            return Ok("Order Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok("Order Deleted");
        }
    }
}