using GeometryEquations.Builder;
using GeometryEquations.Figures;
using GeometryEquations.Structs;
using NUnit.Framework;

namespace GeometryEquations.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TriangleAreaIsCorrect()
        {
            var triangle = new Triangle(
                new Side(0,0,0,2),
                new Side(0,2,3,0),
                new Side(3,0,0,0));
            Assert.AreEqual(3, triangle.GetArea(), 0.00001);
        }

        [Test]
        public void TriangleAreaIsCorrectOnNegativeValues()
        {
            var triangle = new Triangle(
                new Side(-4, 5, -3, 0),
                new Side(-3, 0, 7, 7),
                new Side(7, 7, -4, 5));
            Assert.AreEqual(28.5, triangle.GetArea(), 0.00001);
        }

        [Test]
        public void TriangleShouldHave3Sides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 0, 0),
                new Side(7,7,7,7)));
            Assert.Throws<ArgumentException>(() => new Triangle(
                new Side(0, 0, 0, 2),
                new Side(7, 7, 7, 7)));
            Assert.DoesNotThrow(() => new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 0, 0)));
        }

        [Test]
        public void TriangleSidesShouldBeConnected()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 1, 1)));
            Assert.Throws<ArgumentException>(() => new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(1, 1, 0, 0)));
            Assert.DoesNotThrow(() => new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 0, 0)));
        }

        [Test]
        public void CheckTriangleType()
        {
            var triangle = new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 0, 0));
            Assert.AreEqual(TriangleType.Scalene, triangle.TriangleType);
        }

        [Test]
        public void CheckIfTriangleIsRight()
        {
            var triangle = new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 0, 0));
            var rightTriangle = new Triangle(
                new Side(-1, 0, 3, 0),
                new Side(3, 0, 3, 3),
                new Side(3, 3, -1, 0));
            Assert.AreEqual(false, triangle.IsRight);
            Assert.AreEqual(true, rightTriangle.IsRight);
        }
    }
}
