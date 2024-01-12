using MyLeetCode.TwoSum;

public partial class Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        var actual = Solution.TwoSum(nums, target);
        Assert.Equal(expected, actual);
    }
}