using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(5);
            Vehicle bike = new Vehicle(1);

            Console.WriteLine("Car has gone {0} miles",car.distance);
            Console.WriteLine("Bike has gone "+bike.distance);
            
            car.Move(70.0);
            Console.WriteLine("Car has gone "+car.distance);
            Console.WriteLine("Bike has gone "+bike.distance);
            
        }
    }
}
