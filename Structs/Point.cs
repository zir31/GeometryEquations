namespace GeometryEquations.Structs
{
    public struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; }
        public double Y { get; }

        public override bool Equals(object? other)
        {
            if (other is not Point otherPoint)
                return false;
            return X == otherPoint.X && Y == otherPoint.Y;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Point point1, Point point2)
        {
            return point1.Equals(point2);
        }
        public static bool operator !=(Point point1, Point point2)
        {
            return point1.Equals(point2);
        }
    }
}
