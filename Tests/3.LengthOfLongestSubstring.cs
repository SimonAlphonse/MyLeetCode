using MyLeetCode.LengthOfLongestSubstring;

public partial class Tests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("aab", 2)]
    [InlineData("dvdf", 3)]
    public void LengthOfLongestSubstring(string s, int expected)
    {
        var actual = Solution.LengthOfLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}