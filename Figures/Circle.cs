using GeometryEquations.Structs;

namespace GeometryEquations.Figures
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            Radius = radius;
            ValidateFigure();
        }

        public Circle(double radius, double centerX, double centerY)
        {
            Radius = radius;
            Center = new Point(centerX, centerY);
            ValidateFigure();
        }

        public Point Center { get; }

        public double Radius { get; }

        public override double GetArea()
        {
            return Math.PI* Radius * Radius;
        }

        protected override void ValidateFigure()
        {
            if (Radius < double.Epsilon)
                throw new ArgumentException("Radius value shoud be positive");
        }

        public override bool Equals(object? other)
        {
            if (other == null || other is not Circle otherCircle)
                return false;
            return Radius == otherCircle.Radius && Center == otherCircle.Center;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Center);
        }
    }
}
