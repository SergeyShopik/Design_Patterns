using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyable = new FlyNoWay();
            quackable = new Mute();
        }
        public override void Display()
        {
            Console.WriteLine("Looks like model duck.");
        }
    }
}
