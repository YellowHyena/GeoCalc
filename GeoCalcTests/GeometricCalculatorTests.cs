using GeoCalc.Interfaces;
using GeoCalc.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoCalc.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        #region PerimeterTests

        [TestMethod()]
        [DataRow(1, 4)]
        [DataRow(-1, -4)]
        [DataRow(0.5f, 2)]
        [DataRow(0, 0)]
        [DataRow(float.MaxValue, float.PositiveInfinity)]
        public void GetPerimeterTest_Square(float side, float expected)
        {
            var shape = new Square(side: side);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        [TestMethod()]
        [DataRow(1, 3, 8)]
        [DataRow(-1, 3, 4)]
        [DataRow(0.5f, 2, 5)]
        [DataRow(0, 0, 0)]
        [DataRow(float.MaxValue, float.MinValue, float.NaN)]
        public void GetPerimeter_Rectangle(float height, float width, float expected)
        {
            var shape = new Rectangle(height: height, width: width);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        [TestMethod()]
        [DataRow(2, 12.5f)]
        [DataRow(-2, -12.5f)]
        [DataRow(0.5f, 3.14f)]
        [DataRow(0, 0)]
        [DataRow(float.MaxValue,float.PositiveInfinity)]
        public void GetPerimeterTest_Circle(float radius, float expected)
        {
            var shape = new Circle(radius: radius);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape), 0.1);
        }

        [TestMethod()]
        [DataRow(1, 1, 1, 3)]
        [DataRow(1, -1, 1, 1)]
        [DataRow(0, 0, 0, 0)]
        [DataRow(0.5f, 0.5f, 0.5f, 1.5f)]
        [DataRow(float.MaxValue, float.MaxValue, float.MaxValue, float.PositiveInfinity)]
        public void GetPerimeterTest_Triangle(float a, float b, float c, float expected)
        {
            var shape = new Triangle(sideA: a, sideB: b, sideC: c);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        #endregion

        #region AreaTests
        [TestMethod()]
        [DataRow(1,1)]
        [DataRow(2,4)]
        [DataRow(0.5f,0.25f)]
        [DataRow(-2,4)]
        [DataRow(float.MaxValue, float.PositiveInfinity)] //∞
        public void GetAreaTest_Square(float side, float expected)
        {
            var shape = new Square(side: side);
            Assert.AreEqual(expected, GeometricCalculator.GetArea(shape));
        }

        [TestMethod()]
        [DataRow(1, 1, 1)]
        [DataRow(2, 4, 8)]
        [DataRow(0.5f, 0.5f, 0.25f)]
        [DataRow(-2, 4, -8)]
        [DataRow(float.MaxValue, float.MaxValue, float.PositiveInfinity)]
        public void GetAreaTest_Rectangle(float height, float width, float expected)
        {
            var shape = new Rectangle(height: height, width: width);
            Assert.AreEqual(expected, GeometricCalculator.GetArea(shape));
        }

        [TestMethod()]
        [DataRow(1, 3.14f)]
        [DataRow(2, 12.5f)]
        [DataRow(0.5f, 0.7f)]
        [DataRow(-2, 12.5f)]
        [DataRow(float.MaxValue, float.PositiveInfinity)]
        public void GetAreaTest_Circle(float radius, float expected)
        {
            var shape = new Circle(radius: radius);
            Assert.AreEqual(expected, GeometricCalculator.GetArea(shape), 0.1);
        }

        [TestMethod()]
        [DataRow(1, 1,0.5f)]
        [DataRow(2, 3,3)]
        [DataRow(0.5f, 0.5f, 0.125f)]
        [DataRow(-2, 4,-4)]
        [DataRow(float.MaxValue, float.MaxValue, float.PositiveInfinity)]
        public void GetAreaTest_Triangle(float height, float @base, float expected)
        {
            var shape = new Triangle(height: height, @base: @base);
            Assert.AreEqual(expected, GeometricCalculator.GetArea(shape));
        }
        #endregion

        #region PerimeterSumTests
        [TestMethod()]
        public void GetPerimeterTest_MultipleShapes()
        {
            var expected = 32.5;
            var shape = new IShape[]
            {
                new Circle(radius:2),
                new Square(side:1),
                new Rectangle(height:3, width:2),
                new Triangle(sideA:1, sideB:2, sideC:3)
            };
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape), 0.1);
        }
        #endregion
    }
}