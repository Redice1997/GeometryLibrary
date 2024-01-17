using GeometryLibrary.Exceptions;
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

        /// <summary>
        /// Creates a circle along the radius
        /// </summary>
        /// <exception cref="LessThanZeroException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new LessThanZeroException(radius, nameof(radius));

            this.radius = radius;
        }

        public double Perimeter => 2 * Math.PI * radius;

        public double Square => Math.PI * radius * radius;

        public double Radius => radius;

        public double Diameter => 2 * radius;
    }
}
