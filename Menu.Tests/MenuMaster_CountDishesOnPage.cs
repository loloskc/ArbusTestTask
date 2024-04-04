using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Tests
{
    public class MenuMaster_CountDishesOnPage
    {
        private List<Dish> dishes;
        [SetUp]
        public void Setup()
        {
            dishes = new CreateDefaultCollection().GetDishes();
        }

        [Test]
        public void CountDishesOnPage1_Return3()
        {
            var mMaster = new MenuMaster(3, dishes);

            Assert.That(mMaster.GetCountDishesOnPage(1), Is.EqualTo(3));

        }

        [Test]
        public void CountDishesOnPage1_Return2() 
        {
            var mMaster = new MenuMaster(2, dishes);

            Assert.That(mMaster.GetCountDishesOnPage(1), Is.EqualTo(2));
        }

        [Test]
        public void CountDishesOnPage2_Return2()
        {
            var mMaster = new MenuMaster(2, dishes);

            Assert.That(mMaster.GetCountDishesOnPage(2), Is.EqualTo(2));
        }

        [Test]
        public void CounDishesOnPage3_Return1()
        {
            var mMaster = new MenuMaster(2, dishes);

            Assert.That(mMaster.GetCountDishesOnPage(3), Is.EqualTo(1));
        }
    }
}
