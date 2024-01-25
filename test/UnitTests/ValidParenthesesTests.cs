using LeetcodePractices.Problems.ValidParentheses;

namespace LeetcodePractices.UnitTests;

public class ValidParenthesesTests
{
    private readonly ValidParenthesesSimplest sut;

    public ValidParenthesesTests()
    {
        sut = new ValidParenthesesSimplest();
    }

    [Fact]
    public void ValidParenthesesTests_1()
    {
        // Arrange
        var input = "()";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ValidParenthesesTests_2()
    {
        // Arrange
        var input = "()[]{}";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ValidParenthesesTests_3()
    {
        // Arrange
        var input = "(]";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void ValidParenthesesTests_4()
    {
        // Arrange
        var input = "([)]";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void ValidParenthesesTests_5()
    {
        // Arrange
        var input = "{[]}";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ValidParenthesesTests_6()
    {
        // Arrange
        var input = "]";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void ValidParenthesesTests_7()
    {
        // Arrange
        var input = "((";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void ValidParenthesesTests_8()
    {
        // Arrange
        var input = "){";

        // Act
        var result = sut.IsValid(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void ValidParenthesesTests_9()
    {
        // Arrange
        var input = "(([]){})";
        // Act
        var result = sut.IsValid(input);
        // Assert
        result.Should().BeTrue();
    }
}