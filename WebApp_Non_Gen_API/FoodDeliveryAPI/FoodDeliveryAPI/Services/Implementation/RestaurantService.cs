namespace FoodDeliveryAPI.Services.Implementation
{
    using FoodDeliveryAPI.Models;
    using FoodDeliveryAPI.Repositories.Interfaces;
    using FoodDeliveryAPI.Services.Interfaces;

    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepo _repo;
        public RestaurantService(IRestaurantRepo repo) { _repo = repo; }
        public List<Restaurant> GetAll() => _repo.GetAll();
    }
}
