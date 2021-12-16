using AreaCalcLib;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        [Test]
        public void TriangleAreaCalcTest()
        {
            Triangle tr = new Triangle(3, 4, 5);

            double value = tr.AreaCalc();

            Assert.AreEqual(6, value);
        }

        [Test]
        public void TriangleIsRightAngledTest()
        {
            Triangle tr = new Triangle(3, 4, 5);

            bool value = tr.IsRightAngled();

            Assert.AreEqual(true, value);
        }

        [Test]
        public void CircleAreaCalcTest()
        {
            Circle c = new Circle(6);

            double value = c.AreaCalc();

            Assert.AreEqual(113.09733552923255, value);
        }
    }
}