using MyLeetCode.LongestPalindrome;

public partial class Tests
{
    [Theory]
    [InlineData("cbbd", "bb")]
    public void _5_LongestPalindrome(string s, string expected)
    {
        var actual = new Solution().LongestPalindrome(s);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("babad", new[] { "bab", "aba" })]
    public void _5_LongestPalindromes(string s, string[] expected)
    {
        var actual = new Solution().LongestPalindrome(s);
        Assert.True(expected.Contains(s));
    }
}