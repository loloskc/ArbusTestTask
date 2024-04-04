using Menu.Model;
using Menu.Service;
using NUnit.Framework.Constraints;
using System.Collections.ObjectModel;

namespace Menu.Tests
{
    public class MenuMaster_GetCollectionOnPage
    {
        private List<Dish> dishes;

        [SetUp]
        public void Setup()
        {
            dishes = new CreateDefaultCollection().GetDishes();
        }

        [Test]
        public void GetCollectionOnPage1_Return_Coffee_And_NotCoffee()
        {
            var mMaster = new MenuMaster(2, dishes);
            var expected = new ObservableCollection<Dish>();
            expected.Add(dishes[0]);
            expected.Add(dishes[1]);

            Assert.That(mMaster.GetDishesOnPage(1), Is.EquivalentTo(expected));
        }

        [Test]
        public void GetCollectionOnPage2_Return_Soup_And_Fries()
        {
            var mMaster = new MenuMaster(2, dishes);
            var expected = new ObservableCollection<Dish>();
            expected.Add(dishes[2]);
            expected.Add(dishes[3]);

            Assert.That(mMaster.GetDishesOnPage(2), Is.EquivalentTo(expected));
        }

        [Test]
        public void GetCollectionOnPage3_Return_Burger()
        {
            var mMaster = new MenuMaster(2, dishes);
            var expected = new ObservableCollection<Dish>();
            expected.Add(dishes[4]);

            Assert.That(mMaster.GetDishesOnPage(3), Is.EquivalentTo(expected));
        }

        [Test]
        public void GetCollectionOnPage1_Return_Coffee_NotCoffee_And_Soap()
        {
            var mMaster = new MenuMaster(3,dishes);
            var expected = new ObservableCollection<Dish>();
            expected.Add(dishes[0]);
            expected.Add(dishes[1]);
            expected.Add(dishes[2]);

            Assert.That(mMaster.GetDishesOnPage(1), Is.EquivalentTo(expected));
        }

        [Test]
        public void GetCollectionOnPage2_Return_Fries_And_Burger()
        {
            var mMaster = new MenuMaster(3,dishes);
            var expected = new ObservableCollection<Dish>();
            expected.Add(dishes[3]);
            expected.Add(dishes[4]);

            Assert.That(mMaster.GetDishesOnPage(2), Is.EquivalentTo(expected));

        }
    }
}
