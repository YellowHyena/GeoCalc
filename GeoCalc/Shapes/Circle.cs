using GeoCalc.Interfaces;

namespace GeoCalc.Shapes
{
    public class Circle : IShape
    {
        public float Radius { get; set; } = 0;

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Area() => Radius * Radius * (float)Math.PI;

        /// <summary> Calculates perimeter. </summary>
        /// <returns> r * 2pi </returns>
        public float Perimeter() => Radius * (float)Math.PI * 2;
    }
}
