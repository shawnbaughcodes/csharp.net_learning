using human;
using System;

namespace human_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Samurai cody = new Samurai("Cody");

            Ninja matt = new Ninja("Matt");

            Console.WriteLine(matt.health);

            cody.death_blow(matt);
            Console.WriteLine(matt.health);
        }
    }
}
