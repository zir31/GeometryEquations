using GeometryEquations.Figures;
using GeometryEquations.Structs;

namespace GeometryEquations.Builder
{
    public interface IFigureSelectionStage
    {
        ICircleSelectionStage MakeCircle();
        IPolygonSelectionStage MakePolygon();
    }

    public interface ICircleSelectionStage
    {
        IRadiusSelectionStage AddRadius(double radius);
        IRadiusAndCenterSelectionStage AddRadiusAndCenter(double radius, double centerX, double centerY);
    }

    public interface IRadiusSelectionStage
    {
        Figure Build();
        double GetArea();
    }

    public interface IRadiusAndCenterSelectionStage
    {
        Figure Build();
        double GetArea();
    }
    public interface ITriangleSelectionStage
    {
        IPointSelectionStage AddPoint(double X, double Y);
    }

    public interface IPolygonSelectionStage
    {
        IPointSelectionStage AddPoint(double X, double Y);
    }

    public interface IPointSelectionStage
    {
        IPointSelectionStage AddPoint(double X, double Y);
        double GetArea();
        Figure Build();
    }

    internal class FigureBuilder : ICircleSelectionStage, 
        IRadiusSelectionStage, IRadiusAndCenterSelectionStage,
        IPolygonSelectionStage, IPointSelectionStage
    {
        private Figure figure;

        public static ICircleSelectionStage MakeCircle()
        {
            var builder = new FigureBuilder();
            return builder;
        }

        public IRadiusAndCenterSelectionStage AddRadiusAndCenter(double radius, double centerX, double centerY)
        {
            figure = new Circle(radius, centerX, centerY);
            return this;
        }

        public IRadiusSelectionStage AddRadius(double radius)
        {
            figure = new Circle(radius);
            return this;
        }

        public static IPolygonSelectionStage MakePolygon()
        {
            var builder = new FigureBuilder
            {
                figure = new Polygon()
            };
            return builder;
        }

        public IPointSelectionStage AddPoint(double x, double y)
        {
            ((Polygon)figure).Vertices.Add(new Point(x, y));
            return this;
        }

        public double GetArea()
        {
            return figure.GetArea();
        }

        public Figure Build()
        {
            return figure;
        }
    }
}
