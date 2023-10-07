using FluentAssertions;
using ShapesLibrary;

namespace ShapeLib.Tests
{
    public class SquareTests
    {
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
