using GeoCalc.Interfaces;
namespace GeoCalc.Shapes
{
    public class Circle : IShape
    {
        public float Radius { get; set; } = 0;

        /// <summary> It's a circle :). </summary>
        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Perimeter() => Radius * (float)Math.PI * 2;
        public float Area() => Radius * Radius * (float)Math.PI;
    }
}
