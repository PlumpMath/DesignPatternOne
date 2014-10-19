using System;
using DesignPatternOne.ClassesWithInterfaces;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne
{
    public class MallardDuck : Duck
    {
        private IQuackBehavior quackBehavior;
        private IFlyBehavior flyBehavior;

        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        //public override void display()
        //{
        //    Console.WriteLine("I am a real Mallard Duck");
        //}
    }
}