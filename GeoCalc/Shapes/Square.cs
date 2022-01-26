using GeoCalc.Interfaces;
namespace GeoCalc.Shapes
{
    public class Square : IShape
    {
        public float Side { get; set; } = 0;

        /// <summary> It's a square :). </summary>
        public Square(float side)
        {
            Side = side;
        }

        public float Perimeter() => Side + Side + Side + Side;
        public float Area() => Side * Side;
    }
}
