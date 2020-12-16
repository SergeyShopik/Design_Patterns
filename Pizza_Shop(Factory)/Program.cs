using System;

namespace Pizza_Shop_Factory_
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Egdar's order: {pizza.Name}");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Colt's order: {pizza.Name}");
        }
    }
}
