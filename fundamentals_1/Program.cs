using System;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-255
            for (int i = 1;i < 256;i++)
            {
                Console.WriteLine(i);
            }
            // 1-1000 divisible by 3 and 5
            for (int i = 0; i < 1001; i++)
            {
                if (i % 3 == 0 || i % 5 ==0)
                {
                    Console.WriteLine(i);
                }
            }
            // Fizz for 3, Buzz for 5
            for (int i = 0; i < 1001; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

        }
    }
}
