using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Tests
{
    public class MenuMaster_GetFirstPostionOnAllPage
    {
        private List<Dish> dishes;

        [SetUp]
        public void Setup()
        {
            dishes = new CreateDefaultCollection().GetDishes();
        }

        [Test]
        public void GetFirstPostionOnAllPage_Return_Coffee_Soup_Burger()
        {
            var mMaster = new MenuMaster(2, dishes);

            var expected = new List<Dish>();
            expected.Add(dishes[0]);
            expected.Add(dishes[2]);
            expected.Add(dishes[4]);

            var resuption = mMaster.GetFirstPositionAllPage();
            Assert.That(mMaster.GetFirstPositionAllPage(),Is.EquivalentTo(expected));
        }

        [Test]
        public void GetFirstPositionAllPage_Return_Odd()
        {
            

            for(int i = 0; i < 100; i++)
            {
                var dish = new Dish() { Name = $"{i}" };
                dishes.Add(dish);
            }
            var mMaster = new MenuMaster(2,dishes);

            var arrayDish = new Dish[105];
            dishes.CopyTo(arrayDish);
            var expected = new List<Dish>();

            for(int i = 0;i < 105; i += 2)
            {
                expected.Add(dishes[i]);
            }

            Assert.That(mMaster.GetFirstPositionAllPage(),Is.EquivalentTo(expected));
            
        }


    }
}
