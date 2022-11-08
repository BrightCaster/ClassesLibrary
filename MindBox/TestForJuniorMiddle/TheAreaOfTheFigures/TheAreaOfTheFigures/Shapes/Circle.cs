using TheAreaOfTheFigures.Interfaces;

namespace TheAreaOfTheFigures.Shapes
{
    public class Circle : IShape
    {
        int R;
        public Circle(int r)
        {
            R = r;
        }

        public void printCharacteristics()
        {
            Console.WriteLine($"Radius = {R}");
        }

        public double square()
        {
            return Math.PI * Math.Pow(2, R);
        }
    }
}