namespace ShapesLibrary
{
    public class Triangle : Shape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public override double Area => CalculateArea();

        public Triangle(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a));
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b));
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c));

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException
                    ("Длина любой стороны треугольника всегда должна быть меньше " +
                    "суммы длин двух его других сторон (");
            }

            A = a;
            B = b;
            C = c;
        }

        protected override double CalculateArea()
        {
            var semiPerimeter = (A + B + C) / 2;
            var area =
                Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
            return area;
        }

        public bool IsStraightTriangle()
        {
            return A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2)) ||
                   B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2)) ||
                   C == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A, 2));
        }
    }
}
