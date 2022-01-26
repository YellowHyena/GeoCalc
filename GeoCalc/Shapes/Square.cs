using GeoCalc.Interfaces;

namespace GeoCalc.Shapes
{ /// <summary> It's a shape :). </summary>
    public class Square : IShape
    {
        public float Side { get; set; } = 0;
        public Square(float side)
        {
            Side = side;
        }

        /// <summary> Calculates perimiter of Square.</summary>
        /// <returns> Sum of all sides. </returns>
        public float Perimeter() => Side + Side + Side + Side;
        /// <summary> Calculates Area of Square.</summary>
        /// <returns> Side * Side </returns>
        public float Area() => Side * Side;
    }
}
