using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.Domain
{
    public class ProductOrderFactory
    {
        private int _ProductID;
        public int ProductID
        {
            get { return _ProductID; }
            private set { _ProductID = value; }
        }

        private string _ProductName;
        public string ProductName
        {
            get { return _ProductName; }
            private set { _ProductName = value; }
        }

        private decimal _Price;
        public decimal Price
        {
            get { return _Price; }
            private set { _Price = value; }
        }

        private decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            private set { _Quantity = value; }
        }

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
