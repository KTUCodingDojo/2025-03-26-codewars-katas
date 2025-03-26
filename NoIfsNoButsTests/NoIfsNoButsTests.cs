namespace NoIfsNoButs.Tests
{
    public class NoIfsNoButsTests
    {
        [Fact]
        public void FluentAssertions_Should_Work()
        {
            var sum = 2 + 3;
            sum.Should().Be(5);
        }

        [Theory]
        [InlineData(5, 4, "5 is greater than 4")]
        [InlineData(-4, -7, "-4 is greater than -7")]
        [InlineData(2, 2, "2 is equal to 2")]
        [InlineData(1, 2, "1 is smaller than 2")]
        public void Number_IsGreaterThan(int a, int b, string expected)
        {
            string result = Comparator.Compare(a, b);
            result.Should().Be(expected);
        }

    }
}