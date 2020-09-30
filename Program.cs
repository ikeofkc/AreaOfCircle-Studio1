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
            double areaRaw = Math.PI + radius * radius;
            double area = Math.Round(areaRaw, 3);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
            // Using the same radius, calculate the circumference (2*pi*r) and diameter of the circle (2*r).
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The circumference of a circle with a radius of {radius} is {circumference}");
            Console.WriteLine("What is the miles per gallon of your car:");
            string mphInput = Console.ReadLine();
            double mph = double.Parse(mphInput);
        }
    }
}