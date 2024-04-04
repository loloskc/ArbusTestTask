using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Service
{
    public class MenuMaster
    {

        private readonly int countOnPage;
        private readonly IEnumerable<Dish> dishes;
        public MenuMaster(int countOnPage, IEnumerable<Dish> dishes)
        {
            if(dishes == null)
            {
                throw new Exception("Коллекция пуста");
            }
            if(countOnPage<=0)
            {
                throw new Exception("Количество элементов меньше минимального разрешеного");
            }
            this.dishes = dishes;
            this.countOnPage = countOnPage;
            
        }


        public int GetCountPage()
        {
            if (dishes == null|| dishes.Count() == 0)
                return 1;
            int countPage = dishes.Count() / countOnPage;
            
            if (dishes.Count() % countOnPage != 0)
                countPage++;
            
            return countPage;
            
        }

        

        public ObservableCollection<Dish> GetDishesOnPage(int page)
        {

            var obsCollection = new ObservableCollection<Dish>();
            page--;

            var array = dishes.ToArray();
            int countNow = 0;

            for(int i = page*countOnPage;i<array.Length&&countNow<countOnPage;i++)
            {
                obsCollection.Add(array[i]);
                countNow++;
            }
            return obsCollection;
        }

        public int GetCountDishes()
        {
            if (dishes != null)
                return dishes.Count();
            else
                return 0;
        }
       
        public int GetCountDishesOnPage(int page)
        {
            int countDishes = GetDishesOnPage(page).Count();

            return countDishes;
        }

        public List<Dish> GetFirstPositionAllPage()
        {
            var listFirstPostion = new List<Dish>();
            for(int i = 1; i <= GetCountPage(); i++)
            {
                var dishesPage = GetDishesOnPage((i));
                listFirstPostion.Add(dishesPage[0]);
            }

            return listFirstPostion;
        }
    }
}
