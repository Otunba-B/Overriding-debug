using System;

namespace Overriding_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new AnimalFeedVendingMachine();
            Console.WriteLine(vendingMachine.Dispense(1.0M));
         }
    }
}
