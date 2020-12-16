using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Shop_Factory_
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style deep dish cheese pizza";
            dough = "Thick crust dough";
            sauce = "Plum tomato sauce";

            toppings.Add("Shredded Mozarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza in square slices");
        }
    }
}
