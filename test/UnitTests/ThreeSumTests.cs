namespace LeetcodePractices.UnitTests;

public class ThreeSumTests
{
    private readonly ThreeSumOptimized sut;

    public ThreeSumTests()
    {
        sut = new ThreeSumOptimized();
    }

    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [-1, 0, 1, 2, -1, -4];
        List<List<int>> expected =
            [
                [-1, -1, 2],
                [-1, 0, 1]
            ];

        // Act
        var result = sut.Solution(nums);

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
                [0, 0, 0]
            ];

        // Act
        var result = sut.Solution(nums);

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
                [-1, 0, 1]
            ];

        // Act
        var result = sut.Solution(nums);

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
        var result = sut.Solution(nums);

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
                [0, 0, 0]
            ];

        // Act
        var result = sut.Solution(nums);

        Console.WriteLine(nums.Length);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test6()
    {
        // Arrange
        int[] nums = [-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4];
        List<List<int>> expected =
            [
                [-4, 0, 4],
                [-4, 1, 3],
                [-3, -1, 4],
                [-3, 0, 3],
                [-3, 1, 2],
                [-2, -1, 3],
                [-2, 0, 2],
                [-1, -1, 2],
                [-1, 0, 1]
            ];

        // Act
        var result = sut.Solution(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}