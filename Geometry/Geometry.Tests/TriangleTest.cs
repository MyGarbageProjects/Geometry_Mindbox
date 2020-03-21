using Geometry.Core;
using Xunit;

namespace Geometry.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(10, 10, 10, 43.301)]
        [InlineData(15, 15, 15, 97.427)]
        [InlineData(7, 7, 7, 21.2176)]
        public void CanArea(double side1, double side2, double side3, double expected)
        {
            // arrange 
            var triangle = new Triangle(side1, side2, side3);
            double tolerance = 0.01;
            // act 
            double actual = triangle.Area();
            // assert 
            Assert.InRange(actual, expected - tolerance, expected + tolerance);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(5, 5, 5, false)]
        [InlineData(11, 13, 11, false)]
        public void IsRight(double side1, double side2, double side3, bool expected)
        {
            // arrange 
            var triangle = new Triangle(side1, side2, side3);
            // act 
            bool actual = triangle.IsRightAngle();
            // assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 10, 10, 30)]
        [InlineData(15, 15, 15, 45)]
        [InlineData(7, 7, 7, 21)]
        public void CanPerimeter(double side1, double side2, double side3, double expected)
        {
            // arrange 
            var triangle = new Triangle(side1, side2, side3);
            double tolerance = 0.00001;
            // act 
            double actual = triangle.Perimeter();
            // assert 
            Assert.InRange(actual, expected - tolerance, expected + tolerance);
        }

    }
}
