using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Shop_Factory_
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY style sauce and cheese pizza";
            dough = "Thin crust dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
