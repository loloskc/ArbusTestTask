using Menu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.ViewModel
{
    public partial class PageViewModel : BaseViewModel
    {

        public ObservableCollection<Dish> Dishes { get; private set; } = new();
        MenuMaster menuMaster;

        public PageViewModel()
        {
            var matcha = new Dish { Id = 1,Name= "Matcha", Price=12 };
            var latte = new Dish { Id = 2, Name = "Latte", Price = 42 };
            var smoothie = new Dish { Id = 3, Name = "Smoothie", Price = 1 };
            var gin = new Dish { Id =4,Name = "Gin", Price =4 };
            var eskimo = new Dish { Id = 5, Name = "Eskimo", Price = 12 };
            List<Dish> list = new List<Dish>();
            list.Add(matcha);
            list.Add(smoothie);
            list.Add(gin);
            list.Add(latte);
            list.Add(eskimo);
            menuMaster = new MenuMaster(2, list);
        }


        [RelayCommand]
        public void NextPage()
        {
           if(Page == menuMaster.GetCountPage())
            {
                Page = 1;
                GetCollection();
            }
            else
            {
                Page++;
                GetCollection();
            }
        }   

        [RelayCommand]
        public void PrevPage() 
        {
            if(Page != 1)
            {
                Page--;
                GetCollection();
            }
            else
            {
                Page = menuMaster.GetCountPage();
                GetCollection();
            }
            
        }

        [RelayCommand]
        public void GetCollection()
        {
            var dishes = menuMaster.GetDishesOnPage(Page);
            if (Dishes.Count > 0)
                Dishes.Clear();
            foreach(var dish in dishes)
            {
                Dishes.Add(dish);
            }
        }

    }
}
