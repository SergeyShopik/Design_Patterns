using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    public class HouseBlend : Beverage
    {
        private const double HOUSE_BLEND_COST = 0.89;

        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }
        public override double Cost()
        {
            return HOUSE_BLEND_COST;
        }
    }
}
