using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryTask.Math
{
    public class Common
    {
        
        public static decimal Sqrt(decimal square)
        {
            if (square < 0) return 0;

            decimal root = square / 3;
            int i;
            for (i = 0; i < 32; i++)
                root = (root + square / root) / 2;
            return root;
        }
        
    }
}
