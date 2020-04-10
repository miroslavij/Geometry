using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTask.Implementation
{
    public class Circle: Figure
    {
        double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        protected override double CalculateSquare()
        {
            return System.Math.PI * _radius * _radius;
        }
    }
}
