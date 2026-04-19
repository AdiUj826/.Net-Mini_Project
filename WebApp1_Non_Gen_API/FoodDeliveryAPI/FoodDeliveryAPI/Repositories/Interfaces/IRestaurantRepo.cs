using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Repositories.Interfaces
{
    public interface IRestaurantRepo
    {
        List<Restaurant> GetAll();
    }
}