
namespace UnitTestProject.Domain
{
    public class ProductOrder
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        private decimal _TotalPrice;

        public decimal TotalPrice
        {
            get
            {
                _TotalPrice = Price * Quantity;
                return _TotalPrice;
            }
            set
            {
                _TotalPrice = value;
            }
        }
    }
}