using GeometryCalculator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figure
{
    public class Circle : Abstraction.Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can't be 0 or less than 0");
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
