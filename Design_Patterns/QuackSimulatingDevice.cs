using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class QuackSimulatingDevice
    {
        IQuackable quackable;
        public QuackSimulatingDevice()
        {
            quackable = new ClassicQuack();
        }

        public void MakeQuack()
        {
            quackable.Quack();
        }
    }
}
