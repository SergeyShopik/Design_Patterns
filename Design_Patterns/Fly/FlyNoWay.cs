using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("No skies today...");
        }
    }
}
