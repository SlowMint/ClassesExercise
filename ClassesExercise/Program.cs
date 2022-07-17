using System;

namespace ClassesExercise
{
    class Program
    {
        public static void Main(string[] arg)
        {
            var pickUpTruck = new Car();
            pickUpTruck.Make = "Toyota";
            pickUpTruck.Model = "Tacoma";
            pickUpTruck.Year = 2020;

                Console.WriteLine($"Your truck is a {pickUpTruck.Year} {pickUpTruck.Make} {pickUpTruck.Model}");
        }
    }
}
