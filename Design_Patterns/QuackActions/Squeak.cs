using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class Squeak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
