using GeoCalc.Interfaces;
namespace GeoCalc
{
    public static class GeometricCalculator
    {
        /// <summary> Gets the perimeter from an <see cref="IShape"/> class. </summary>
        /// <param name="shape">Class who inherits from <see cref="IShape"/></param>
        /// <returns> The perimeter. </returns>
        public static float GetPerimeter(IShape shape) => shape.Perimeter();

        /// <summary> Gets the area from an <see cref="IShape"/> class. </summary>
        /// <param name="shape">Class who inherits from <see cref="IShape"/></param>
        /// <returns> The area. </returns>
        public static float GetArea(IShape shape) => shape.Area();

        /// <summary> Gets the sum of the perimeters of multiple <see cref="IShape"/>-inherited classes. </summary>
        /// <param name="shapes"> Array of classes who inherit from <see cref="IShape"/></param>
        /// <returns> The sum of all perimeters in array. </returns>
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
