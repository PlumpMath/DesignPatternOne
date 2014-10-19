using System;
using DesignPatternOne.ClassesWithInterfaces;

namespace DesignPatternOne
{
    class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            //Duck mallard = new MallardDuck();
            //mallard.performQuack();
            //mallard.performFly();

            //Duck model = new ModelDuck();
            //model.performFly();
            //model.setFlyBehavior(new FlyRocketPowered());
            //model.performFly();

            Duck mainDuck = new Duck();

            Console.WriteLine("pheli duck...");
            mainDuck.setFlyBehavior(new FlyWithWings());
            mainDuck.performFly();
            mainDuck.setQuackBehavior(new Quack());
            mainDuck.performQuack();

            Console.WriteLine("\n");

            Console.WriteLine("dosri duck...");
            mainDuck.setFlyBehavior(new FlyNoWay());
            mainDuck.performFly();
            mainDuck.setQuackBehavior(new Sqeak());
            mainDuck.performQuack();

            Console.ReadKey();

        }
    }
}
