using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class MallardDuck: Duck
    {
           public MallardDuck()
    {
        this.quackBehavior = new Quack();
        this.flyBehavior = FlyWithWings(); 
    }
        public void display()
    {
        Console.WriteLine("I'm a real Mallard Duck");
    }
    }
}
