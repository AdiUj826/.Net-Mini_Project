using FoodDeliveryAPI.Models;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Services.Interfaces
{
    public interface IMenuService
    {
        List<Menu> GetAll();
        Menu GetById(int id);
        void Add(Menu menu);
        void Update(int id, Menu menu);
        void Delete(int id);
    }
}