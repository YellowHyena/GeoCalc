using GeoCalc.Interfaces;
namespace GeoCalc.Shapes
{
    public class Square : IShape
    {
        float Side { get; }

        /// <summary> It's a square :). </summary>
        public Square(float side) => Side = side;

        public float Perimeter() => Side + Side + Side + Side;
        public float Area() => Side * Side;
    }
}
