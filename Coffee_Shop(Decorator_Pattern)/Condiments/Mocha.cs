using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    public class Mocha : CondimentDecorator
    {
        //beverage instance variable needed in order to properly override
        //Cost() and GetDescrption() methods
        public Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
