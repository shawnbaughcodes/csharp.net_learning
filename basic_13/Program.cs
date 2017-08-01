using System;
using System.Collections.Generic;
namespace basic_13
{
    public class basic_13
    {
        // PRINT 1-255
        public static void print_255()
        {
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        // PRINT ODD 1-255
        public static void odd_255()
        {
            for (int i = 1; i < 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void sum_255()
        {
            int sum = 0;
            for (int i = 0; i < 255; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        public static void iterate_array()
        {
            int[] num_arr = new int[4] {1,2,3,4};
            for (int i = 0; i < num_arr.Length; i++)
            {
                Console.WriteLine(num_arr[i]);
            }
        }
        // FIND MAX
        public static void max()
        {
            int max = 0;
            int[] arr = new int[6] {3,6,3,100,56,87};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        // GET AVERAGE
        public static void avg()
        {
            int sum = 0;
            int avg = 0;
            int[] arr = new int[5] {1,2,3,4,5};
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(avg = sum / arr.Length);
        }
        // ARRAY WITH ODD NUMBERS
        public static void odd_arr()
        {
            int[] arr = new int[255];
            int[] new_arr = new int[255];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1 + i;
                if (arr[i] % 2 != 0)
                {
                    new_arr[i] = arr[i];
                    Console.WriteLine(new_arr[i]);
                }
            }
        }
        // GREATER THAN Y
        public static void gty()
        {
            int[] arr = new int[4] {11,2,32,4};
            int y = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > y)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        // SQUARE THE VALUES
        public static void stval()
        {
            int num = 0;
            int[] arr = new int[4] {11,23,36,41};
            for (int i = 0; i < arr.Length; i++)
            {
                num = arr[i] * 2;
                Console.WriteLine(num);
            }
        }
        // ELIMINATE NEGATIVE NUMBERS
        public static void ennum()
        {
            int[] arr = new int[4] {1,2,-3,5};
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            Console.WriteLine(arr[i]);

            }
        }
        // NUMBER TO STRING
        public static void numtostr()
        {
            object[] arr = new object[5] {1,2,-3,4,5};
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)arr[i] < 0)
                {
                    arr[i] = "Dojo";
                }
            Console.WriteLine(arr[i]);
            }
        }
        
        public static void Main(string[] args){
            // print_255();
            // odd_255();
            // sum_255();
            // iterate_array();
            // max();
            // avg();
            // odd_arr();
            // gty();
            // stval();
            // ennum();
            numtostr();
        }
    }
}
