using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometryEquations.Figures
{
    public abstract class Figure
    {
        public abstract double GetArea();
        protected abstract void ValidateFigure();
    }
}
