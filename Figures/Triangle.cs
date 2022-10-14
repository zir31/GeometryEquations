using GeometryEquations.Structs;

namespace GeometryEquations.Figures
{
    public enum TriangleType
    {
        Scalene = 1, // no two sides are the same length
        Isosceles = 2, // two sides are the same length and one differs
        Equilateral = 3, // all sides are the same length
    }
    internal class Triangle : Polygon
    {
        private readonly List<Side> Sides = new();
        public Triangle(params Side[] sides)
        {
            Sides = sides.ToList();
            ValidateFigure();
        }

        public TriangleType TriangleType { get; private set; }
        public bool IsRight { 
            get 
            {
                return Math.Abs(
                    Math.Pow(Sides.ElementAt(2).Length, 2) - 
                    (Math.Pow(Sides.ElementAt(0).Length, 2) + Math.Pow(Sides.ElementAt(1).Length, 2))) < 0.0001;
            } }
        
        public override double GetArea()
        {
            var p = 0.5 * Sides.Sum(x => x.Length);
            return Math.Sqrt(p * 
                (p - Sides.ElementAt(0).Length) * 
                (p - Sides.ElementAt(1).Length) *
                (p - Sides.ElementAt(2).Length));
        }

        protected override void ValidateFigure()
        {
            if (Sides.Count != 3)
                throw new ArgumentException("Triangle should have 3 sides");

            foreach (var side in Sides)
            {
                if (!Sides.Any(s => s.End == side.Start))
                    throw new ArgumentException("Triangle sides should connect to each other");
            }
            TriangleType = GetTriangleType(Sides.ElementAt(0).Length, 
                Sides.ElementAt(1).Length, Sides.ElementAt(2).Length);
        }

        private TriangleType GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c && c == a)
                return TriangleType.Equilateral;
            else if (a == b || a == c || b == c)
                return TriangleType.Isosceles;
            else
                return TriangleType.Scalene;
        }
    }
}
