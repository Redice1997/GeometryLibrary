using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Models
{
    public sealed class Triangle : IShape2D
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        /// <summary>
        /// Creates a triangle along three side lengths
        /// </summary>
        /// <exception cref="GeometryException"></exception>
        public Triangle(double a, double b, double c)
        {
            if ((a + b > c &&
                 b + c > a &&
                 c + a > b) is false)
                throw new GeometryException($"The sides 'a: {a}, b: {b}, c: {c}' do not form a triangle");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Perimeter => a + b + c;

        public double Square => GetSquare();
        private double GetSquare()
        {
            var p = Perimeter / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRectangular => CheckRectangularity();
        private bool CheckRectangularity()
        {
            var sides = new[] { a, b, c };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2); 
        }
    }
}
