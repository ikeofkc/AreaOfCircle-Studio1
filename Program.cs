using System;
using InputData;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input and convert. Check for valid input. 
            Console.WriteLine("Enter a radius of circular race track in miles:");
            string radiusInput = Console.ReadLine();
            while (double.Parse(radiusInput) < 0.0) {
                Console.WriteLine("Please enter a positive number: ");
                radiusInput = Console.ReadLine();
            }
            Console.WriteLine("What is the miles per gallon of your car:");
            string mpgInput = Console.ReadLine();
            while (double.Parse(mpgInput) < 0.0) {
                Console.WriteLine("Please enter a positive number: ");
                mpgInput = Console.ReadLine();
            }
            // Store circle info in separate class 
            Circle.radius = Math.Round(double.Parse(radiusInput));
            Circle.area = Math.Round(Math.PI + Circle.radius * Circle.radius,3);
            Circle.circumference = Math.Round(2 * Math.PI * Circle.radius);
            // Store mpg info into variables in car class
            Car.mpg = double.Parse(mpgInput);
            // Calculate gallons used for input data
            double gallonsUsed = Math.Round(Circle.circumference / Car.mpg,3);
            // Output messages to user
            Console.WriteLine($"Fun fact, the area of the race track with a radius of {Circle.radius} miles is {Circle.area} square miles.");
            Console.WriteLine($"The race track is {Circle.circumference} miles long and it will take {gallonsUsed} gallons of gas to travel around the race track.");
        }
    }
}