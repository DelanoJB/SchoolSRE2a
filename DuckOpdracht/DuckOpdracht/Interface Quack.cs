using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Interface_Quack
    {
        public class Quack : QuackBehavior
        {
            public void Quack()
            {
                Console.WriteLine("Quack");
            }
        }
    }
}
