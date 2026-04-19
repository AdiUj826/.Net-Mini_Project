namespace FoodDeliveryAPI.Repositories.Implementation
{
    using FoodDeliveryAPI.Models;
    using FoodDeliveryAPI.Repositories.Interfaces;

    public class RestaurantRepo : IRestaurantRepo
    {
        public List<Restaurant> GetAll() => new() { new Restaurant { Id = 1, Name = "Dominos" } };
    }
}
