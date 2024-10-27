// Shape.cs
namespace ShapesExample
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        // Constructor for the Shape class
        public Shape(double height, double width)
        {
            Height = height;
            Width = width;
            Console.WriteLine("Shape constructor called.");
        }

        // Abstract method for calculating area
        public abstract double CalculateArea();

        public void DisplayDimensions()
        {
            Console.WriteLine($"Height: {Height}, Width: {Width}");
        }
    }
}
