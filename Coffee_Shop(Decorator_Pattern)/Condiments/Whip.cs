using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    public class Whip : CondimentDecorator
    {
        public Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
