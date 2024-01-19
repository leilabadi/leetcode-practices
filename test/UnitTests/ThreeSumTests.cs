namespace LeetcodePractices.UnitTests;

public class ThreeSumTests
{
    private readonly ThreeSum sut;

    public ThreeSumTests()
    {
        sut = new ThreeSum();
    }

    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [-1, 0, 1, 2, -1, -4];
        List<List<int>> expected =
            [
                new() { -1, -1, 2 },
                new() { -1, 0, 1 }
            ];

        // Act
        var result = sut.Solution1(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        int[] nums = [0, 0, 0];
        List<List<int>> expected =
            [
                new() { 0, 0, 0 }
            ];

        // Act
        var result = sut.Solution1(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        int[] nums = [-1, 0, 1, 0];
        List<List<int>> expected =
            [
                new() { -1, 0, 1 }
            ];

        // Act
        var result = sut.Solution1(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test4()
    {
        // Arrange
        int[] nums = [];
        List<List<int>> expected = [];

        // Act
        var result = sut.Solution1(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test5()
    {
        // Arrange
        int[] nums = new int[3000];
        for (int i = 0; i < 3000; i++)
        {
            nums[i] = 0;
        }

        List<List<int>> expected =
            [
                new() { 0, 0, 0 }
            ];

        // Act
        var result = sut.Solution1(nums);

        Console.WriteLine(nums.Length);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}