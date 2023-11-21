using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Triangle Area Calculator");

            // Get the base and height from the user
            Console.Write("Enter the base of the triangle: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate the area of the triangle
            double area = CalculateTriangleArea(baseLength, height);

            // Display the result
            Console.WriteLine($"The area of the triangle is: {area}");
        }

        // Function to calculate the area of a triangle
        static double CalculateTriangleArea(double baseLength, double height)
        {
            return (baseLength * height) / 2;
        }
    }
}
