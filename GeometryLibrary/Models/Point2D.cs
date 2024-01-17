using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Models
{
    internal struct Point2D
    {
        public Point2D() { }
        public Point2D(double x, double y) 
        {
            X = x; Y = y;
        }

        public double X { get; init; }
        public double Y { get; init; }

        public static Point2D operator +(Point2D left, Point2D right) => new Point2D
        {
            X = left.X + right.X,
            Y = left.Y + right.Y,
        };

        public static Point2D operator -(Point2D left, Point2D right) => new Point2D
        {
            X = left.X - right.X,
            Y = left.Y - right.Y,
        };

        public double Distance => Math.Sqrt(X * X + Y * Y);
    }
}
