using GeoCalc.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoCalc.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        #region PerimeterTests
        [TestMethod()]
        [DataRow(2,8)]
        [DataRow(-2, -8)]
        [DataRow(0.5f, 2)]
        [DataRow(0,0)]
        public void GetPerimeterTest_Square(float side, float expected)
        {
            var shape = new Square(side: side);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape));
        }

        [TestMethod()]
        [DataRow(2,12.5f)]
        [DataRow(-2,-12.56f)]
        [DataRow(0.5f,3.14)]
        public void GetPerimeterTest_Circle(float radius, float expected)
        {
            var shape = new Circle(radius: radius);
            Assert.AreEqual(expected, GeometricCalculator.GetPerimeter(shape),0.01);
        }

        #endregion

        [TestMethod()]
        public void GetAreaTest_Square()
        {
            var shape = new Square(side: 2);
            Assert.AreEqual(4, GeometricCalculator.GetArea(shape));
            shape.Side = -3;
            Assert.AreEqual(9, GeometricCalculator.GetArea(shape)); //Ska man kunna ha negativa?
            shape.Side = 0.5f;
            Assert.AreEqual(0.25, GeometricCalculator.GetArea(shape)); //också inte realistiskt
            shape.Side = 0;
            Assert.AreEqual(0, GeometricCalculator.GetArea(shape));
        }
    }
}