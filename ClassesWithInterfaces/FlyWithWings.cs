using System;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne.ClassesWithInterfaces
{
    class FlyWithWings : IFlyBehavior 
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
