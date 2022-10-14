using GeometryEquations.Builder;
using NUnit.Framework;

namespace GeometryEquations.Tests
{
    [TestFixture]
    public class PolygonTests
    {
        [Test]
        public void ComplexPolygonAreaIsCorrect()
        {
            var complexPolygon = FigureBuilder.MakePolygon()
                .AddPoint(1, 4)
                .AddPoint(2, 6)
                .AddPoint(4, 455)
                .AddPoint(3, 45)
                .AddPoint(334, -124)
                .AddPoint(35, 57)
                .AddPoint(327, 3)
                .AddPoint(25, 76)
                .Build();

            Assert.AreEqual(6971, complexPolygon.GetArea(), 0.00001);
        }

        [Test]
        public void PolygonAreaIsCorrect()
        {
            var complexPolygon = FigureBuilder.MakePolygon()
                .AddPoint(-1, -20)
                .AddPoint(-4, 0)
                .AddPoint(10, 123)
                .AddPoint(245, 21)
                .Build();

            Assert.AreEqual(17688, complexPolygon.GetArea(), 0.00001);
        }
    }
}