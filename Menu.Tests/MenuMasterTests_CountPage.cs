using Menu.Model;
using Menu.Service;

namespace Menu.Tests
{
    public class MenuMasterTests_CountPage
    {
        private List<Dish> dishes;
        [SetUp]
        public void Setup()
        {
            dishes = new CreateDefaultCollection().GetDishes();
        }

        [Test]
        public void CountPage_Return3()
        {

            var mMaster = new MenuMaster(2, dishes);


            Assert.That(mMaster.GetCountPage(), Is.EqualTo(3));
        }

        [Test]
        public void CountPage_Return5()
        {
            var mMaster = new MenuMaster(1, dishes);

            Assert.That(mMaster.GetCountPage(), Is.EqualTo(5));
        }

        [Test]
        public void CountPage_Return2()
        {
            var mMaster = new MenuMaster(3, dishes);

            Assert.That(mMaster.GetCountPage(),Is.EqualTo(2));
        }

        [Test]
        public void CountPage_Return_Ex_If_List_Is_Null()
        {
            var mMaster = new MenuMaster(0, null);

            Assert.That(mMaster.GetCountPage(),Is.EqualTo(1));
        }

        [Test]
        public void CountPage_Return1()
        {
            var mMaster = new MenuMaster(5, dishes);

            Assert.That(mMaster.GetCountPage(),Is.EqualTo(1));
        }

        [Test]
        public void CountPage_Return_2()
        {
            var mMaster = new MenuMaster(4, dishes);

            Assert.That(mMaster.GetCountPage(), Is.EqualTo(2));
        }

        [Test]
        public void CountPage_Return_42()
        {
            for(int i = 0; i < 79; i++)
            {
                var dish = new Dish() { Name = $"Test{i}" };
                dishes.Add(dish);
            }

            var mMaster = new MenuMaster(2,dishes);

            Assert.That(mMaster.GetCountPage(), Is.EqualTo(42));
        }
        [Test]
        public void CountPage_Return_43()
        {
            for (int i = 0; i < 80; i++)
            {
                var dish = new Dish() { Name = $"Test{i}" };
                dishes.Add(dish);
            }

            var mMaster = new MenuMaster(2, dishes);

            Assert.That(mMaster.GetCountPage(), Is.EqualTo(43));
        }
    }
}