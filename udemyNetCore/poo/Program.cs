using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman test = new CarSalesman("steve", "rogers");
            Console.WriteLine(test.fullName);
            test.sell();

            RetailSalesPerson test2 = new RetailSalesPerson("iron", "man");
            Console.WriteLine(test2.fullName);
            test2.sell();
        }
    }
}
