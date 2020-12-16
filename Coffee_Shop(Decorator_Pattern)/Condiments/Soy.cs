using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    public class Soy : CondimentDecorator
    {
        private const double CONDIMENT_COST_TALL = 0.15;
        private const double CONDIMENT_COST_GRANDE= 0.20;
        private const double CONDIMENT_COST_VENTI = 0.25;


        new public Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            double cost = beverage.Cost();

            if (beverage.GetSize() == Size.TALL)
            {
                cost += CONDIMENT_COST_TALL;
            } else if (beverage.GetSize() == Size.GRANDE)
            {
                cost += CONDIMENT_COST_GRANDE;
            } else if (beverage.GetSize() == Size.VENTI)
            {
                cost += CONDIMENT_COST_VENTI;
            }

            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
