using Microsoft.AspNetCore.Mvc;
using FoodDeliveryAPI.Services.Interfaces;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_service.GetById(id));

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _service.Add(customer);
            return Ok("Customer Added");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Customer customer)
        {
            _service.Update(id, customer);
            return Ok("Customer Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok("Customer Deleted");
        }
    }
}