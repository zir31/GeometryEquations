using GeometryEquations.Builder;
using GeometryEquations.Figures;
using GeometryEquations.Structs;
using NUnit.Framework;

namespace GeometryEquations.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void BuildedTrianglesAreasAreEqualToNormalOnes()
        {
            var triangle = new Triangle(
                new Side(0, 0, 0, 2),
                new Side(0, 2, 3, 0),
                new Side(3, 0, 0, 0));
            var buildedTriangle = FigureBuilder.MakePolygon()
                .AddPoint(0, 0).AddPoint(0, 2).AddPoint(3, 0)
                .Build();
            Assert.AreEqual(3, triangle.GetArea(), 0.00001);
            Assert.AreEqual(3, buildedTriangle.GetArea(), 0.00001);
        }

        [Test]
        public void CircleFromBuilderEqualsCircleFromConstructor()
        {
            var circleFromBuilder = FigureBuilder.MakeCircle().AddRadiusAndCenter(3, 0, 0).Build();
            Assert.AreEqual(new Circle(3, 0, 0), circleFromBuilder);
        }
    }
}
