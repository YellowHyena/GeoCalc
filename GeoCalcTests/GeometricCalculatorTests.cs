using GeoCalc.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoCalc.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        #region PerimeterTests

        [TestMethod()]
        [DataRow(2, 8)]
        [DataRow(-2, -8)]
        [DataRow(0.5f, 2)]
        [DataRow(0, 0)]
        [DataRow(int.MaxValue, 0)]
        public void GetPerimeterTest_Square(float side, float expected)
        {
            var shape = new Square(side: side);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        [TestMethod()]
        [DataRow(1, 3, 8)]
        [DataRow(2, 3, 10)]
        public void GetPerimeter_Rectangle(float height, float width, float expected)
        {
            var shape = new Rectangle(height: height, width: width);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        [TestMethod()]
        [DataRow(2, 12.5f)]
        [DataRow(-2, -12.56f)]
        [DataRow(0.5f, 3.14f)]
        [DataRow(0, 0)]
        public void GetPerimeterTest_Circle(float radius, float expected)
        {
            var shape = new Circle(radius: radius);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape), 0.01);
        }

        [TestMethod()]
        [DataRow(5, 5, 5, 15)]
        public void GetPerimeterTest_Triangle(float a, float b, float c, float expected)
        {
            var shape = new Triangle(sideA: a, sideB: b, sideC: c);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        #endregion

        [TestMethod()]
        public void GetAreaTest_Square(float side, float expected)
        {
            var shape = new Square(side: side);
            Assert.AreEqual(expected, GeometricCalculator.GetArea(shape));
        }

        [TestMethod()]
        public void GetAreaTest_Triangle(float height, float @base, float expected)
        {
            var shape = new Triangle(height: height, @base: @base);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }
    }
}