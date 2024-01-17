using GeometryLibrary.Models;
using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary
{
    /// <summary>
    /// Helps to create shapes and work with them
    /// </summary>
    public static class Geometry
    {
        /// <summary>
        /// Creates a triangle along three side lengths
        /// </summary>
        /// <exception cref="GeometryException"></exception>
        public static Triangle CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        /// <summary>
        /// Creates a circle along the radius
        /// </summary>
        /// <exception cref="LessThanZeroException"></exception>
        public static Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Calculates an area of the shape
        /// </summary>
        public static double GetSquare(IHaveSquare shape)
        {
            return shape.Square;
        }

        /// <summary>
        /// Calculates a perimeter of the shape
        /// </summary>
        public static double GetPerimeter(IHavePerimeter shape)
        {
            return shape.Perimeter;
        }
    }
}