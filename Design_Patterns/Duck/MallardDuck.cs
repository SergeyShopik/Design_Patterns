using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyable = new FlyWithWings();
            quackable = new ClassicQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Looks like mallard duck.");
        }
    }
}
