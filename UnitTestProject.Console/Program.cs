using System;
using UnitTestProject.Domain;


namespace UnitTestProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var productOrder = new ProductOrderFactory(1, "Apples", 1000.05m, 1)
                                    .WithSeasonDiscount()
                                    .WithSpecialDiscount()
                                    .Build();






        }
    }
}
