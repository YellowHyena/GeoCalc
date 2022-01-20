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
        /// <returns> Side*4. </returns>
        public float Perimeter() => Side * 4;
        /// <summary> Calculates perimiter of Square.</summary>
        /// <returns></returns>
        public float Area() => Side * Side;
    }
}
