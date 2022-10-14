using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryEquations.Structs;

namespace GeometryEquations.Figures
{
    public class Polygon : Figure
    {
       public List<Point> Vertices = new List<Point>();

        public override double GetArea()
        {
            double sum = 0;
            for (int i = 0; i < Vertices.Count; i++)
            {
                var j = (i + 1) % Vertices.Count;
                var p1 = Vertices[i];
                var p2 = Vertices[j];

                sum += p1.X * p2.Y - p1.Y * p2.X;
            }
            return Math.Abs(sum) / 2;
        }

        //There's room for improvement. Checking that figure's sides doesn't intersect with each other for instance
        protected override void ValidateFigure()
        {
            
        }
    }
}
