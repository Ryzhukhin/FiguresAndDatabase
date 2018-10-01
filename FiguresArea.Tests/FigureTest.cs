using System;
using FiguresArea.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresArea.Tests
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void CircleArea_Pi_Multiply_Radius_in_Square_5_return_78()
        {
            Circle circle = new Circle(5);
            double area = Math.Floor(circle.Area);
            Assert.AreEqual(78, area);
        }

        [TestMethod]
        public void CircleArea_Pi_return_zero()
        {
            Circle circle = new Circle();
            double area = Math.Floor(circle.Area);
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TriangleArea_return_9()
        {
            Triangle triangle = new Triangle(4,5,6);
            double area = Math.Floor(triangle.Area);
            Assert.AreEqual(9, area);
        }

        [TestMethod]
        public void TriangleArea_for_empty_return_0()
        {
            Triangle triangle = new Triangle();
            double area = Math.Floor(triangle.Area);
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TriangleArea_righttriangle_return_true()
        {
            Triangle triangle = new Triangle();
            bool area = triangle.RightTriangle();
            Assert.IsTrue(area);
        }
    }
}
