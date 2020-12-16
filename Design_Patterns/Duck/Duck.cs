using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public abstract class Duck
    {
        public IQuackable quackable;
        public IFlyable flyable;

        public Duck()
        {

        }

        public void SetFlyBehavior(IFlyable f)
        {
            flyable = f;
        }
        public void SetQuackBehavior(IQuackable q)
        {
            quackable = q;
        }

        public abstract void Display();
        public void PerformFly()
        {
            flyable.Fly();
        }
        public void PerformQuack()
        {
            quackable.Quack();
        }
    }
   
}
