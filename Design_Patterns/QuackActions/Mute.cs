using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class Mute : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("<silence>");
        }
    }
}
