using GeoCalc;
using GeoCalc.Interfaces;
using GeoCalc.Shapes;
public static class Program
{
    public static void Main()
    {
        var square = new Square(side:10);
        var calc = new GeometricCalculator();
        Console.WriteLine(GeometricCalculator.GetPerimeter(square));
    }
}