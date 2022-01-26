using GeoCalc.Interfaces;

namespace GeoCalc.Shapes
{
    /// <summary> It's a triangle :) </summary>
    /// <seealso cref="GeoCalc.Interfaces.IShape" />
    public class Triangle : IShape
    {
        float SideA { get; set; } = 0;
        float SideB { get; set; } = 0;
        float SideC { get; set; } = 0;

        float Height { get; set; } = 0;
        float Base { get; set; } = 0;
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

        /// <summary> Calculates the area of Triangle. </summary>
        /// <returns> Height * Base / 2.</returns>
        public float Area() => Height * Base / 2;
        /// <summary> Calculates the perimeter of Triangle. </summary>
        /// <returns> SideA + SideB + SideC. </returns>
        public float Perimeter() => SideA + SideB + SideC;
    }
}
