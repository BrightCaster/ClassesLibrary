using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAreaOfTheFigures.Interfaces;

namespace TheAreaOfTheFigures.Shapes
{
    public class Triangle : IShape
    {
        int a;
        int b;
        int c;
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void printCharacteristics() => Console.WriteLine($"A={a}, B={b}, C={c}");

        public double square()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool isRectangular() => a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b;
    }
}
