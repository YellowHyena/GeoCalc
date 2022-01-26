using GeoCalc.Interfaces;
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
