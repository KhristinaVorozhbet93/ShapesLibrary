namespace ShapesLibrary
{
    public class Circle : Shape
    {
        private readonly double _pi = 3.14;
        public double Radius { get; }
        public override double Area => CalculateArea();

        public Circle(double radius)
        {
            if (radius <= 0) 
                throw new ArgumentOutOfRangeException(nameof(radius));
            Radius = radius;
        }

        protected override double CalculateArea()
        {
            return _pi * Math.Pow(Radius, 2);
        }
    }
}
