// Rectangle.cs
namespace ShapesExample
{
    public class Rectangle : Shape
    {
        // Constructor for the Rectangle class, calling the base class constructor
        public Rectangle(double height, double width) : base(height, width)
        {
            Console.WriteLine("Rectangle constructor called.");
        }

        // Implementing the CalculateArea method for a rectangle
        public override double CalculateArea()
        {
            return Height * Width;
        }

        public void DisplayRectangleInfo()
        {
            Console.WriteLine("This is a rectangle.");
            DisplayDimensions();
            Console.WriteLine($"Area: {CalculateArea()}");
        }
    }
}
