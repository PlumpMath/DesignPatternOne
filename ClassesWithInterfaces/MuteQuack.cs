using System;
using DesignPatternOne.Interfaces;

namespace DesignPatternOne.ClassesWithInterfaces
{
    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
