using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}
