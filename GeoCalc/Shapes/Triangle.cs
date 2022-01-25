using GeoCalc.Interfaces;

namespace GeoCalc.Shapes
{
    public class Triangle : IShape
    {
        float SideA { get; set; } = 0;
        float SideB { get; set; } = 0;
        float SideC { get; set; } = 0;

        float Height { get; set; } = 0;
        float Base { get; set; } = 0;

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public Triangle (float height, float @base)
        {
            Height = height;
            Base = @base;
        }

        public float Area() => (Height * Base)/2;

        public float Perimeter() => SideA + SideB + SideC;
    }
}
