namespace ShapesLibrary
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        protected abstract double CalculateArea();
    }
}
