using System;
using System.Collections.Generic;

namespace functions
{
    public class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello, how you doin?");
        }
        public static void Main(string[] args)
        {
            // SayHello();
        }
        public static void SayWuddup(string name)
        {
            Console.WriteLine("Hello, {0}, how are you doing today?", name);
        }
        SayWuddup("Andrew");
    }
}
