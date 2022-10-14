using GeometryEquations.Builder;
using GeometryEquations.Figures;
using NUnit.Framework;


namespace GeometryEquations.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            var circle = FigureBuilder.MakeCircle().AddRadius(3).Build();

            Assert.AreEqual(28.274333882308138, circle.GetArea());
        }

        [Test]
        public void CircleRadiusShouldBePositiveNumber()
        {
            Assert.Throws<ArgumentException>(() => FigureBuilder.MakeCircle().AddRadiusAndCenter(-3, 0, 0).Build());
            Assert.Throws<ArgumentException>(() => FigureBuilder.MakeCircle().AddRadiusAndCenter(0, 0, 0).Build());
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.DoesNotThrow(() => new Circle(3));
            Assert.DoesNotThrow(() => FigureBuilder.MakeCircle().AddRadius(3).Build());
        }

        [Test]
        public void CirclesWithDifferentCentersShouldNotBeEqual()
        {
            var circle = new Circle(3);
            var otherCircle = new Circle(3, 0, 1);

            Assert.AreNotEqual(otherCircle, circle);
        }
    }
}
