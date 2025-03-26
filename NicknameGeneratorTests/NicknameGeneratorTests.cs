

namespace NicknameGenerator.Tests
{
    public class NicknameGeneratorTests
    {
        NicknameGenerator nicknameGenerator = new NicknameGenerator();
        [Fact]
        public void FluentAssertions_Should_Work()
        {
            var sum = 2 + 2;
            sum.Should().Be(4);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 7, 12)]
        [InlineData(-1, 1, 0)]
        public void Xunit_Theory_Should_Work(int a, int b, int expected)
        {
            var result = a + b;
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("Robert", "Rob")]
        [InlineData("Kimberly", "Kim")]
        [InlineData("Samantha", "Sam")]
        public void Generate_When3rdLetterIsConsonant_ReturnFirst3Letters(string name, string expected)
        {
            string nickname = nicknameGenerator.GenerateNickname(name);
            nickname.Should().Be(expected);
        }

        [Theory]
        [InlineData("Jeannie", "Jean")]
        [InlineData("Douglas", "Doug")]
        [InlineData("Gregory", "Greg")]
        public void Generate_When3rdLetterIsVowel_ReturnFirst4Letters(string name, string expected)
        {
            string nickname = nicknameGenerator.GenerateNickname(name);
            nickname.Should().Be(expected);
        }

        [Theory]
        [InlineData("Abc")]
        [InlineData("Ab")]
        [InlineData("A")]
        [InlineData("")]
        public void Generate_StringLengthLessThan4(string nameTooShort)
        {
            string nickname = nicknameGenerator.GenerateNickname(nameTooShort);
            nickname.Should().Be("Error: Name too short");
        }
    }
}