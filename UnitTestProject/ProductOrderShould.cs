using System;
using System.Collections.Generic;
using System.Text;

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
            var poFactory = new ProductOrderFactory(1,"Orange",100m,10);

            //act
            var pOrder = poFactory.Build();

            //assert
            Assert.That(100 * 10, Is.EqualTo(pOrder.TotalPrice));
        }
    }
}
