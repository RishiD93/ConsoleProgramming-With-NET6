// Triangle.cs
namespace ShapesExample
{
    public class Triangle : Shape
    {
        // Constructor for the Triangle class, calling the base class constructor
        public Triangle(double height, double width) : base(height, width)
        {
            Console.WriteLine("Triangle constructor called.");
        }

        // Implementing the CalculateArea method for a triangle
        public override double CalculateArea()
        {
            return 0.5 * Height * Width;
        }

        public void DisplayTriangleInfo()
        {
            Console.WriteLine("This is a triangle.");
            DisplayDimensions();
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
}
