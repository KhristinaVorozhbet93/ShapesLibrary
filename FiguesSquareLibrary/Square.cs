namespace ShapesLibrary
{
    public class Square : Shape
    {
        public double A { get; }
        public override double Area => CalculateArea();

        public Square(double a)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a));
            A = a;
        }

        protected override double CalculateArea()
        {
            return Math.Pow(A, 2);
        }
    }
}
