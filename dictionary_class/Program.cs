using System;
using System.Collections.Generic;
namespace dictionary_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> profile = new Dictionary<string,string>();
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);

            List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }
            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0);
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }
        }
    }
}
