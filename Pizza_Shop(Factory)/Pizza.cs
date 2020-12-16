using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Shop_Factory_
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine($"Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(string topping in toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 C");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cut pizza in diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Put pizza in official PizzaStore box");
        }
    }
}
