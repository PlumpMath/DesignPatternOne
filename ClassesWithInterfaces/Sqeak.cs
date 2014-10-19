using System;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne.ClassesWithInterfaces
{
    class Sqeak : IQuackBehavior 
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
