using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAreaOfTheFigures.Interfaces;

namespace TheAreaOfTheFigures.Shapes
{
    public class Figure
    {
        Circle? circle;
        Triangle? triangle;
        public Figure(Circle circle)
        {
            this.circle = circle;
        }
        public Figure(Triangle triangle)
        {
            this.triangle = triangle;
        }

        public Circle? getCircle() => circle;
        public Triangle? getTriangle() => triangle;
    }
}
