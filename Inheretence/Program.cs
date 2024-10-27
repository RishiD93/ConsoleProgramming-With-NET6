// Program.cs
using System;
using ShapesExample;

namespace ShapesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Rectangle object using the constructor
            Console.WriteLine("Creating a Rectangle object:");
            Rectangle rectangle = new Rectangle(5, 10);
            rectangle.DisplayRectangleInfo();

            Console.WriteLine();

            // Create a Triangle object using the constructor
            Console.WriteLine("Creating a Triangle object:");
            Triangle triangle = new Triangle(5, 10);
            triangle.DisplayTriangleInfo();
        }
    }
}
