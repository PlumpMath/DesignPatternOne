using System;
using DesignPatternOne.ClassesWithInterfaces;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne
{
    class ModelDuck : Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        //public override void display()
        //{
        //    Console.WriteLine("I am model duck");
        //}
    }
}
