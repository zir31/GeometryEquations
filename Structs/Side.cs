using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryEquations.Structs
{
    internal struct Side
    {
        public Side(double startX, double startY, double endX, double EndY)
        {
            Start = new Point(startX, startY);
            End = new Point(endX, EndY);
        }

        public Side(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public Point Start { get; }
        public Point End { get; }

        public double Length
        {
            get
            {
                return Math.Sqrt((End.X - Start.X) * (End.X - Start.X) +
                    (End.Y - Start.Y) * (End.Y - Start.Y));
            }
        }
    }
}
