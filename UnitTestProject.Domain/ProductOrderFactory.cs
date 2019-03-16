using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.Domain
{
    public class ProductOrderFactory
    {
        private int _ProductID;

        private string _ProductName;

        private decimal _Price;

        private decimal _Quantity;

        public ProductOrderFactory(int ProductID, string ProductName, decimal Price, decimal Quantity)
        {
            _ProductID = ProductID;
            _ProductName = ProductName;
            _Price = Price;
            _Quantity = Quantity;
        }

        public ProductOrderFactory WithSeasonDiscount()
        {
            _Price = _Price / 20;

            return this;
        }

        public ProductOrderFactory WithSpecialDiscount()
        {
            _Price = _Price / 10;

            return this;
        }

        public ProductOrder Build()
        {
            return new ProductOrder { ProductID = _ProductID, ProductName = _ProductName, Price = _Price, Quantity = _Quantity };
        }

    }
}
