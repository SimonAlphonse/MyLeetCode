using MyLeetCode.FindMedianSortedArrays;

public partial class Tests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2)]
    [InlineData(new[] { 1, 2 }, new[] {3, 4}, 2.5)]
    public void _4_FindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
    {
        var actual = new Solution().FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(expected, actual);
    }
}