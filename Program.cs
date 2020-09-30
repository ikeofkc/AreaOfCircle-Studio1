using System;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set input and convert to double
            Console.WriteLine("Enter a radius:");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);
            double area = Math.Round(Math.PI + radius * radius,3);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
            // Using the same radius, calculate the circumference (2*pi*r) and diameter of the circle (2*r).
            double circumference = Math.Round(2 * Math.PI * radius);
            Console.WriteLine($"The circumference of a circle with a radius of {radius} is {circumference}");
            Console.WriteLine("What is the miles per gallon of your car:");
            string mphInput = Console.ReadLine();
            double mph = double.Parse(mphInput);
            double gallonsUsed = Math.Round(circumference / mph,3);
            Console.WriteLine($"It will take {gallonsUsed} gallons of gas to travel around a a circle with a circumference of {circumference}");
            
        }
    }
}