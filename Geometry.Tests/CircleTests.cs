using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;
using GeometryLibrary.Models;
using GL = GeometryLibrary;

namespace Geometry.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CreateCircle_ValidRadius_ShouldCreate()
        {
            //arrange
            var rand = new Random();
            var radius = rand.NextDouble() * rand.Next(int.MaxValue);

            //act
            var c = GL.Geometry.CreateCircle(radius);

            //assert
            Assert.Equal(radius, c.Radius);
        }

        [Fact]
        public void CreateCircle_InvalidRadius_ShouldThrow()
        {
            //arrange
            var rand = new Random();
            var radius = -1 * rand.NextDouble() * rand.Next(int.MaxValue);

            //act
            var act = () => GL.Geometry.CreateCircle(radius);

            //assert
            Assert.Throws<LessThanZeroException>(act);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0.5, Math.PI)]
        [InlineData(1000, 2000 * Math.PI)]
        public void GetPerimeter_ValidRadius_ShouldWorkCorrect(double radius, double expected)
        {
            //arrange
            var circle = new Circle(radius);

            //act
            var actual = GL.Geometry.GetPerimeter(circle);

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, Math.PI)]
        [InlineData(0.5, Math.PI / 4)]
        public void GetSquare_ValidRadius_ShouldWorkCorrect(double radius, double expected)
        {
            //arrange
            var circle = new Circle(radius);

            //act
            var actual = GL.Geometry.GetSquare(circle);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}