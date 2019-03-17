using System;
using UnitTestProject.Domain;


namespace UnitTestProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample program

            var productOrder = new ProductOrderFactory(1, "Apples", 1000.05m, 1).Build();
                                    






        }
    }
}
