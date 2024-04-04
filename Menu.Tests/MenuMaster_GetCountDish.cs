using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Tests
{
    public class MenuMaster_GetCountDish
    {
        private List<Dish> dishes;

        [SetUp]
        public void Setup()
        {
            dishes = new CreateDefaultCollection().GetDishes();
        }

        [Test]
        public void GetCount_Return_5()
        {
            var mMaster = new MenuMaster(3, dishes);

            Assert.That(mMaster.GetCountDishes(), Is.EqualTo(5));
        }

        [Test]
        public void GetCount_Return_6()
        {
            dishes.Add(new Dish { Name = "Soap2" });
            var mMaster = new MenuMaster(3, dishes);

            Assert.That(mMaster.GetCountDishes(), Is.EqualTo(6));
        }

        [Test]
        public void GetCount_Returns_Ex_1() 
        {
            var mMaster = new MenuMaster(0,null);

            Assert.That(mMaster.GetCountDishes(), Is.EqualTo(0));
        }

        [Test]
        public void GetCount_Return_Ex_2()
        {

            var mMaster = new MenuMaster(0, dishes);

            Assert.Throws<Exception>(() => mMaster.GetCountDishes());
        }
    }
}
