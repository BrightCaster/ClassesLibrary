using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TheAreaOfTheFigures.Shapes;
using TheAreaOfTheFigures.Interfaces;

namespace TheAreaOfTheFigures.Tests
{
    public class Tests
    {
        [Fact]
        public void CreatingFigures()
        {
            IShape circle = new Circle(15);
            IShape triangle = new Triangle(3,4,5);
            Assert.True(circle is Circle);
            Assert.True(triangle is IShape);
            Assert.True(new Triangle(3, 4, 5).isRectangular());
            Assert.False(new Triangle(3, 5, 5).isRectangular());
        }
        [Fact]
        public void UnNamingFirgures()
        {
            IShape circle = new Circle(15);
            IShape triangle = new Triangle(3, 4, 5);
            Figure shape1 = new Figure(new Circle(15));
            Figure shape2 = new Figure(new Triangle(3, 4, 5));
            Assert.True(shape1.getCircle() is Circle);
            Assert.False(shape2.getCircle() is Circle);
            Assert.Equal(circle.square(), shape1.getCircle()?.square());
            Assert.True(shape2.getTriangle() is Triangle);
            Assert.False(shape1.getTriangle() is Triangle);
            Assert.Equal(triangle.square(), shape2.getTriangle()?.square());

        }
    }
}
