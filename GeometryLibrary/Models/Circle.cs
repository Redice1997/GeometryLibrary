using GeometryLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Models
{
    public sealed class Circle : IShape2D
    {
        private readonly double radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Must be greater than zero");

            this.radius = radius;
        }

        public double Perimeter => GetPerimeter();
        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double Sqare => GetSquare();
        public double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
