namespace GeoCalc.Interfaces
{
    /// <summary>
    /// Interface for shapes.
    /// </summary>
    public interface IShape
    {
        /// <summary> Calculates the perimeter of a shape. </summary>
        /// <returns> The perimeter </returns>
        public float Perimeter();
        /// <summary> Calculates the area of a shape. </summary>
        /// <returns> The area </returns>
        public float Area();
    }
}
