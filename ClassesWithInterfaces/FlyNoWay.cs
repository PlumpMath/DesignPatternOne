using System;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne.ClassesWithInterfaces
{
    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I cant fly");
        }
    }
}
