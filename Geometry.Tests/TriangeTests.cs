using GeometryLibrary.Exceptions;
using GeometryLibrary.Models;
using System;
using GL = GeometryLibrary;


namespace Geometry.Tests
{
    public class TriangeTests
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(5, 5, 1)]
        [InlineData(3, 4, 5)]
        [InlineData(13, 12, 5)]
        [InlineData(12.3, Math.PI, 13.856)]
        public void CreateTriange_ValidSides_ShouldCreate(double a, double b, double c)
        {
            //arrange

            //act
            var t = GL.Geometry.CreateTriangle(a, b, c);

            //assert
            Assert.NotNull(t);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 2, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 1, 2)]
        [InlineData(2, -2, 2)]
        [InlineData(2, 2, -2)]
        public void CreateTriangle_InvalidSides_ShouldThrow(double a, double b, double c)
        {
            //arrange

            //act
            var act = () => GL.Geometry.CreateTriangle(a, b, c);

            //assert
            Assert.Throws<GeometryException>(act);
        }

        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(5, 5, 1, 11)]
        [InlineData(3, 4, 5, 12)]
        [InlineData(13, 12, 5, 30)]
        public void GetPerimeter_ValidSides_ShouldWorkCorrect(double a, double b, double c, double p)
        {
            //arrange
            var triangle = new Triangle(a, b, c);

            //act
            var actual = GL.Geometry.GetPerimeter(triangle);

            //assert
            Assert.Equal(p, actual);
        }

        [Theory]
        [InlineData(1, 1, 1, 0.433)]
        [InlineData(5, 5, 1, 2.487)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(13, 12, 5, 30)]
        public void GetSquare_ValidRadius_ShouldWorkCorrect(double a, double b, double c, double s)
        {
            // arrange
            var triangle = new Triangle(a, b, c);

            //act
            var actual = GL.Geometry.GetSquare(triangle);

            //assert
            Assert.Equal(s, actual, 3, MidpointRounding.AwayFromZero);
        }

        [Theory]
        [InlineData(1, 1, 1, false)]
        [InlineData(5, 5, 1, false)]
        [InlineData(3, 4, 5, true)]
        [InlineData(13, 12, 5, true)]
        [InlineData(12.3, Math.PI, 13.856, false)]
        public void IsRectangular_ValidSides_ShouldBeCorrect(double a, double b, double c, bool isRect)
        {
            //arrange

            //act
            var t = GL.Geometry.CreateTriangle(a, b, c);

            //assert
            Assert.Equal(isRect, t.IsRectangular);
        }
    }
}
