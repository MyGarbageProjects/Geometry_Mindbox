using Geometry.Core;
using Xunit;

namespace Geometry.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(3, 28.274)]
        [InlineData(4, 50.265)]
        [InlineData(5.6, 98.52)]
        public void CanArea(double radius, double expected)
        {
            // arrange 
            var circle = new Circle(radius);
            double tolerance = 0.01;
            // act 
            double actual = circle.Area();
            // assert 
            Assert.InRange(actual, expected - tolerance, expected + tolerance);
        }

        [Theory]
        [InlineData(3, 18.85)]
        [InlineData(4, 25.133)]
        [InlineData(5.6, 35.185)]
        public void CanPerimeter(double radius, double expected)
        {
            // arrange 
            var circle = new Circle(radius);
            double tolerance = 0.01;
            // act 
            double actual = circle.Perimeter();
            // assert 
            Assert.InRange(actual, expected - tolerance, expected + tolerance);
        }
    }
}
