using FluentAssertions;
using ShapesLibrary;

namespace ShapeTests
{
    public class ShapesTests
    {
        //Треугольник
        [Fact]
        public void Triangle_has_correct_props()
        {
            var triangle = new Triangle(6, 8, 10);

            triangle.A.Should().Be(6);
            triangle.B.Should().Be(8);
            triangle.C.Should().Be(10);
        }

        [Theory]
        [InlineData(-6, 8, 10)]
        [InlineData(6, -8, 10)]
        [InlineData(6, 8, -10)]
        [InlineData(0, 8, 10)]
        [InlineData(6, 0, 10)]
        [InlineData(6, 8, 0)]
        public void Triangle_creation_with_negative_sides_rejected(double a, double b, double c)
        {
            FluentActions.Invoking(() => new Triangle(a, b, c))
                 .Should()
                 .Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(19, 8, 10)]
        [InlineData(6, 17, 10)]
        [InlineData(6, 8, 15)]
        public void Triangle_creation_with_incorrect_sides_rejected(double a, double b, double c)
        {
            FluentActions.Invoking(() => new Triangle(a, b, c))
                 .Should()
                 .Throw<ArgumentException>();
        }

        [Fact]
        public void Area_of_triangle_with_sides_6_8_10_should_be_24()
        {
            var triangle = new Triangle(6, 8, 10);

            triangle.Area.Should().Be(24);
        }


        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(3, 5, 4)]
        [InlineData(4, 3, 5)]
        public void Triangle_with_sides_3_4_5_should_be_straight(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var isStraight = triangle.IsStraightTriangle();

            isStraight.Should().Be(true);
        }

        [Fact]
        public void Triangle_and_circle_and_Square_has_common_parrent()
        {
            var triangle = new Triangle(6, 8, 10);
            var circle = new Circle(5);
            var square = new Square(3);

            triangle.Should().BeAssignableTo<Shape>();
            circle.Should().BeAssignableTo<Shape>();
            square.Should().BeAssignableTo<Shape>();

        }

        //Круг
        [Fact]
        public void Circle_has_correct_props()
        {
            var circle = new Circle(6);

            circle.Radius.Should().Be(6);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(0)]
        public void Circle_creation_with_negative_radius_rejected(double radius)
        {
            FluentActions.Invoking(() => new Circle(radius))
                 .Should()
                 .Throw<ArgumentException>();
        }

        [Fact]
        public void Area_of_circle_with_radius_5_should_be_78()
        {
            var circle = new Circle(5);

            circle.Area.Should().Be(78.5);
        }

        //Квадрат
        [Fact]
        public void Square_has_correct_props()
        {
            var square = new Square(3); 

            square.A.Should().Be(3);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(0)]
        public void Square_creation_with_negative_side_rejected(double side)
        {
            FluentActions.Invoking(() => new Square(side))
                 .Should()
                 .Throw<ArgumentException>();
        }

        [Fact]
        public void Area_of_square_with_side_3_should_be_9()
        {
            var square = new Square(3);

            square.Area.Should().Be(9);
        }
    }
}