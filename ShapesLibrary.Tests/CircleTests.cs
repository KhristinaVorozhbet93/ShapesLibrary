using FluentAssertions;

namespace ShapesLibrary.Tests
{
    public class CircleTests
    {
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
    }
}
