using GeoCalc.Interfaces;
using GeoCalc.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoCalc
{
    public class GeometricCalculator
    {
        public static float GetPerimeter(IShape shape) => shape.Perimeter();
        public static float GetArea(IShape shape) => shape.Area();
    }
}
