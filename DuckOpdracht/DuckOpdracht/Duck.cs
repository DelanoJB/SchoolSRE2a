using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Duck
    {
        QuackBehavior quackBehavior;

        public void performanceQuack()
        {
            quackBehavior.Quack();
        }


        public interface QuackBehavior
        {
            void Quack();
        }


        public interface FlyBehavior
        {
            void Fly();
        }
    }


}
}