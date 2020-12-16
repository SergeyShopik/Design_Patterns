using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class ClassicQuack : IQuackable
    {
        void IQuackable.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
