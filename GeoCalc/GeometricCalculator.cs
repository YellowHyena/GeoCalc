﻿using GeoCalc.Interfaces;
using GeoCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public static class GeometricCalculator
    {
        public static float GetPerimeter(IShape shape) => shape.Perimeter();
        public static float GetArea(IShape shape) => shape.Area();
        public static float GetPerimeter(IShape[] shapes)
        {
            float sum = 0;
            foreach (var shape in shapes)
            {
                sum += GetPerimeter(shape);
            }
            return sum;
        }
    }
}
