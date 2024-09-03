using GeometryCalculator.Figure;
using GeometryCalculator.Abstraction;

namespace CalculatorPresentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Shape triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
            Console.WriteLine($"Is Right Triangle: {(triangle as Triangle).IsRightTriangle()}");
        }
    }
}
