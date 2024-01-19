namespace LeetcodePractices.UnitTests;

public class TwoSumTests
{
    private readonly TwoSum sut;

    public TwoSumTests()
    {
        sut = new TwoSum();
    }

    [Fact]
    public void Test1()
    {
        // Arrange
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        int[] expected = [0, 1];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        int[] nums = [3, 2, 4];
        int target = 6;
        int[] expected = [1, 2];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        int[] nums = [0, 4, 3, 0];
        int target = 0;
        int[] expected = [0, 3];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test4()
    {
        // Arrange
        int[] nums = [-1, -2, -3, -4, -5];
        int target = -8;
        int[] expected = [2, 4];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test5()
    {
        // Arrange
        int[] nums = [1, 3, 4, 7, 9];
        int target = 8;
        int[] expected = [0, 3];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test6()
    {
        // Arrange
        int[] nums = [10, 20, 30, 40, 50];
        int target = 90;
        int[] expected = [3, 4];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test7()
    {
        // Arrange
        int[] nums = [1, 1];
        int target = 2;
        int[] expected = [0, 1];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test8()
    {
        // Arrange
        int[] nums = [2, 5, 5, 11];
        int target = 10;
        int[] expected = [1, 2];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test9()
    {
        // Arrange
        int[] nums = [3, 3];
        int target = 6;
        int[] expected = [0, 1];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Test10()
    {
        // Arrange
        int[] nums = [0, 4, 3, 0];
        int target = 7;
        int[] expected = [1, 2];

        // Act
        var result = sut.Solution2(nums, target);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}