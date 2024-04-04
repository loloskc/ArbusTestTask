using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Tests
{
    public class CreateDefaultCollection
    {
        public List<Dish> dishes;
        public List<Dish> GetDishes()
        {
            dishes = new List<Dish>();
            var dish1 = new Dish() { Name = "Coffee" };
            var dish2 = new Dish() { Name = "NotCoffee" };
            var dish3 = new Dish() { Name = "Soup" };
            var dish4 = new Dish() { Name = "Fries" };
            var dish5 = new Dish() { Name = "Burger" };
            dishes.Add(dish1);
            dishes.Add(dish2);
            dishes.Add(dish3);
            dishes.Add(dish4);
            dishes.Add(dish5);

            return dishes;
        }
    }
}
