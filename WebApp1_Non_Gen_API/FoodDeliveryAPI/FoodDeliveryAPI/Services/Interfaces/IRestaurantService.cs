namespace FoodDeliveryAPI.Services.Interfaces
{
    using FoodDeliveryAPI.Models;
    public interface IRestaurantService
    {
        List<Restaurant> GetAll();
    }
}