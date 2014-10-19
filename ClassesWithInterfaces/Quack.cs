using System;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne.ClassesWithInterfaces
{
    class Quack : IQuackBehavior 
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
