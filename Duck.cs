using System;
using DesignPatternOne.ClassesWithInterfaces;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne
{
    public class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;
        //IFlyBehavior _flyBehavior = new FlyWithWings();
         //IQuackBehavior _quackBehavior = new Quack();

        public Duck()
        {

        }

        public void display()
        {
        }



        public void performFly()
        {
            _flyBehavior.fly();
        }

        public void performQuack()
        {
            _quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }
    }
}
