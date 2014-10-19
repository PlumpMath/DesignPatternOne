using System;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne.ClassesWithInterfaces
{
    class FlyRocketPowered : IFlyBehavior 
    {
        public void fly()
        {
            Console.WriteLine("I am flying with a rocket");
        }
    }
}
