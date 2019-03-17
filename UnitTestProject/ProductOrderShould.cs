using NUnit.Framework;

using UnitTestProject.Domain;

namespace UnitTestProject
{
    [TestFixture]
    public class ProductOrderShould
    {
        [Test]
        public void ReturnTotalPriceOfOrder()
        {
            //arrange
            var poFactory = new ProductOrderFactory(1, "Orange", 100m, 10);
            var sut = poFactory.Build();

            //act

            //assert
            Assert.That(sut.TotalPrice, Is.EqualTo(1000));
        }

        [Test]
        public void SetTotalPriceOfOrder()
        {
            //arrange
            var poFactory = new ProductOrderFactory(1, "Grapes", 200m, 10);
            var sut = poFactory.Build();

            //act
            sut.TotalPrice = 100;

            //assert
            Assert.That(sut.TotalPrice, Is.EqualTo(100));
        }

        [Test]
        public void SetPriceOfOrder()
        {
            //arrange
            var poFactory = new ProductOrderFactory(1, "Banana", 1000m, 100);
            var sut = poFactory.Build();

            //act
            sut.TotalPrice = 500m;

            //assert
            Assert.That(sut.Price,Is.EqualTo(5));
        }

        [Test]
        public void SetSeasonDiscount()
        {
            //arrange
            var sut = new ProductOrderFactory(1, "JackFruit", 3000m, 100);

            //act
            sut = sut.WithSeasonDiscount();

            //assert
            Assert.That(sut.Price, Is.EqualTo(150));
        }

        [Test]
        public void SetSpecialDiscount()
        {
            //arrange 
            var sut = new ProductOrderFactory(2, "Mango", 500m, 1);

            //act
            sut = sut.WithSpecialDiscount();
                            
            //assert
            Assert.That(sut.Price, Is.EqualTo(50));
        }
    }
}