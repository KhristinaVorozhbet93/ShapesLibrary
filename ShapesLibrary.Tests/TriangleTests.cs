using FluentAssertions;

namespace ShapesLibrary.Tests
{
    public class TriangleTests
    {
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
        public void Triangle_and_circle_has_common_parrent()
        {
            var triangle = new Triangle(6, 8, 10);
            var circle = new Circle(5);

            triangle.Should().BeAssignableTo<Shape>();
            circle.Should().BeAssignableTo<Shape>();
        }
    }
}
