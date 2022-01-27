using GeoCalc.Interfaces;

namespace GeoCalc.Shapes
{
    public class Triangle : IShape
    {
        float SideA { get; }
        float SideB { get; }
        float SideC { get; }

        float Height { get; }
        float Base { get; }

        /// <summary>
        /// A <see cref="Triangle"/> to be used when calculating perimeter.
        /// </summary>
        /// <param name="sideA">The side a.</param>
        /// <param name="sideB">The side b.</param>
        /// <param name="sideC">The side c.</param>
        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        /// <summary>
        /// A <see cref="Triangle"/> to be used when calculating area.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="base">The base.</param>
        public Triangle(float height, float @base)
        {
            Height = height;
            Base = @base;
        }

        public float Area() => Height * Base / 2;
        public float Perimeter() => SideA + SideB + SideC;
    }
}
