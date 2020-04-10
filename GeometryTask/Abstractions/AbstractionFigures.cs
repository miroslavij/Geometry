using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTask
{
    public abstract class Figure
    {
        public string Name { get; protected set; }
        protected bool _calc = false;

        protected double _square  = 0.0;
        abstract protected double CalculateSquare();

        public double GetSquare()
        {
            if (_calc != true)
            {
                _square = CalculateSquare();
                _calc = true;               
            }
            return _square;
        }        
    }

}
