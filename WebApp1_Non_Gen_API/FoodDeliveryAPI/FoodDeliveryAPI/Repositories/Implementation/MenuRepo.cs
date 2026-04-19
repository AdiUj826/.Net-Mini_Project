using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryAPI.Repositories.Implementation
{
    public class MenuRepo : IMenuRepo
    {
        private static List<Menu> menus = new List<Menu>()
        {
            new Menu { Id = 1, ItemName = "Pizza", Price = 200 }
        };

        public List<Menu> GetAll() => menus;

        public Menu GetById(int id) => menus.FirstOrDefault(x => x.Id == id);

        public void Add(Menu menu)
        {
            menu.Id = menus.Count + 1;
            menus.Add(menu);
        }

        public void Update(int id, Menu menu)
        {
            var data = menus.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                data.ItemName = menu.ItemName;
                data.Price = menu.Price;
            }
        }

        public void Delete(int id)
        {
            var data = menus.FirstOrDefault(x => x.Id == id);
            if (data != null)
            {
                menus.Remove(data);
            }
        }
    }
}