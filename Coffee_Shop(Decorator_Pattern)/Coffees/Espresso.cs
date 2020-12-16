using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    public class Espresso : Beverage
    {
        private const double ESPRESSO_COST = 1.99;
        public Espresso()
        {
            description = "Espresso";
        }

        public override string GetDescription()
        {
            return description;
        }
        public override double Cost()
        {
            return ESPRESSO_COST;
        }
    }
}
