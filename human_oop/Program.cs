using System;
using human;

namespace human_oop

{
    class Program
    {
        static void Main(string[] args)
        {
            Human cody = new Human("Cody");

            Human matt = new Human("Matt");

            matt.attack(cody);
            matt.attack(cody);
            matt.attack(cody);
            cody.attack(matt);

            Console.WriteLine("Matt's health is {0}",matt.health);
            Console.WriteLine("Cody's health is {0}",cody.health);
        }
    }
}
