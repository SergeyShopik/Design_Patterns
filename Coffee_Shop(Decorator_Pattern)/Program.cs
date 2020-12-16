using System;

namespace Coffee_Shop_Decorator_Pattern_
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.GetDescription() + " $" + espresso.Cost());

            Beverage beverage1 = new HouseBlend();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());

            Beverage beverage2 = new Espresso();
            beverage2 = new Soy(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

        }
    }
}
