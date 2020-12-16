using System;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();

            Console.WriteLine("Normal model duck's behavior: ");
            model.PerformFly();
            model.PerformQuack();
            Console.WriteLine("\nModel duck's behavior changed during runtime: ");
            model.SetFlyBehavior(new FlyWithRocketPower());
            model.PerformFly();

            Console.WriteLine("\nQuack implementation without duck object: ");
            QuackSimulatingDevice button = new QuackSimulatingDevice();
            button.MakeQuack();
        }
    }
}
