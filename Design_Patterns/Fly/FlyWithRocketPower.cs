using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class FlyWithRocketPower : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying subsonic speed!!!");
        }
    }
}
