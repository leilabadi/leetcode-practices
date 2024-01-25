using LeetcodePractices.Problems.LongestSubstringWithoutRepeat;

namespace LeetcodePractices.UnitTests;

public class LongestSubstringTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    [InlineData("au", 2)]
    [InlineData("dvdf", 3)]
    [InlineData("abba", 2)]
    [InlineData("aab", 2)]
    [InlineData("abcb", 3)]
    [InlineData("tmmzuxt", 5)]
    [InlineData("bbtablud", 6)]
    public void Solution_GivenString_ReturnsLengthOfLongestSubstringWithoutRepeat(string s, int expected)
    {
        // Arrange
        LongestSubstringOptimized sut = new();

        // Act
        int length = sut.Solution(s);

        // Assert
        length.Should().Be(expected);
    }
}