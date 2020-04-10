using GeometryTask.Math;
using System;
using System.Collections.Generic;
using System.Text;


namespace GeometryTask.Implementation
{
    public class Triangle : Figure
    {
        double _s1;
        double _s2;
        double _s3;

        public Triangle(double s1, double s2, double s3)
        {
            _s1 = s1;
            _s2 = s2;
            _s3 = s3;
        }

        public bool IsRectangular()
        {
            return (_s1 * _s1 + _s2 * _s2 == _s3 * _s3) ||
                   (_s3 * _s3 + _s2 * _s2 == _s1 * _s1) ||
                   (_s1 * _s1 + _s3 * _s3 == _s2 * _s2); 

        }

        protected override double CalculateSquare()
        {
            double p = (_s1 + _s2 + _s3) / 2.0;

            return System.Math.Sqrt(p * (p -_s1) * (p - _s2) * (p - _s3));
        }
    }
}
