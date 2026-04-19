using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using FoodDeliveryAPI.Services.Interfaces;
using System.Collections.Generic;

namespace FoodDeliveryAPI.Services.Implementation
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepo _repo;

        public MenuService(IMenuRepo repo)
        {
            _repo = repo;
        }

        public List<Menu> GetAll() => _repo.GetAll();
        public Menu GetById(int id) => _repo.GetById(id);
        public void Add(Menu menu) => _repo.Add(menu);
        public void Update(int id, Menu menu) => _repo.Update(id, menu);
        public void Delete(int id) => _repo.Delete(id);
    }
}