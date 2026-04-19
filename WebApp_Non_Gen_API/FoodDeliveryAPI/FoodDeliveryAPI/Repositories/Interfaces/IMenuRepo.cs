using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Repositories.Interfaces
{
    public interface IMenuRepo
    {
        List<Menu> GetAll();
        Menu GetById(int id);
        void Add(Menu menu);
        void Update(int id, Menu menu);
        void Delete(int id);
    }
}