using GeoCalc.Interfaces;

namespace GeoCalc.Shapes
{
    public class Rectangle : IShape
    {
        float Height { get; set; } = 0;
        float Width { get; set; } = 0;

        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public float Perimeter() => (Height * 2) + (Width * 2);

        public float Area() => Height * Width;
    }
}
