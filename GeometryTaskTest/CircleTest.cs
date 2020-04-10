using System;
using Bogus;
using GeometryTask.Implementation;

using Xunit;

namespace GeometryTaskTest
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1.0)]
        [InlineData(2.0)]
        [InlineData(2.5)]
        public void SquareTheory(double value)
        {
            var circle = new Circle(value);
            var result = circle.GetSquare();
            Assert.True(result == Math.PI || result == Math.PI * 4.0);          
        }

        [Fact]
        public void SquareBogus()
        {
            var d = new Faker().Random.Double(0.0);
            var i = new Faker().Random.UInt(0, 1000);
            double r = i + d;
            var circle = new Circle(r);
            var result = circle.GetSquare();
            Assert.True(result == Math.PI * r*r);
        }
    }
}
