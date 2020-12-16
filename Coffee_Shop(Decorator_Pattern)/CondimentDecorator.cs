using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        //decorators cannot exist without beverages so reimplement GetDescription()
        public override abstract string GetDescription();
        new public Size GetSize()
        {
            return beverage.GetSize();
        }
    }
}
