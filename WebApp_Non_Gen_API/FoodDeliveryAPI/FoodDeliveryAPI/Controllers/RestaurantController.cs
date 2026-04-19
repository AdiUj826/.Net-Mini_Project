using Microsoft.AspNetCore.Mvc;
using FoodDeliveryAPI.Services.Interfaces;
using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _service;

        public RestaurantController(IRestaurantService service)
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
            return Ok($"Get Restaurant with ID {id}");
        }

        // CREATE
        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            return Ok("Restaurant Created");
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult Update(int id, Restaurant restaurant)
        {
            return Ok($"Restaurant {id} Updated");
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Restaurant {id} Deleted");
        }
    }
}