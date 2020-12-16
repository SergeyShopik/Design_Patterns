using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop_Decorator_Pattern_
{
    //all beverages and abstract CondimentDecorator inherit from Beverage
    //so they be the same type
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        public Size size = Size.TALL;
        public string description;

        public void SetSize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return size;
        }

        //beverage can exist without decorator so GetDescription() is not abstract
        public abstract string GetDescription();
        public abstract double Cost();
    }
}
