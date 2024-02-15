using System;

namespace MyLeetCode.LongestPalindrome
{
    public class Solution
    {
        public static void Main()
        {

        }

        public string LongestPalindrome(string s)
        {
            return s.Length switch
            {
                < 2 => default,
                _ => GetLongestPalindrome(s)
            };
        }

        private static string GetLongestPalindrome(string s)
        {
            HashSet<string> set = [];

            for (int offset = 0; offset < s.Length - 1; offset++)
            {
                for (int length = 2; length < s.Length; length++)
                {
                    if (IsPanlindrome(s, offset, length))
                        set.Add(string.Join(string.Empty, s.Skip(offset).Take(length)));
                }
            }

            return set.OrderByDescending(x => x.Length).First();
        }

        private static bool IsPanlindrome(string s, int offset, int length)
        {
            for (int x = 0; offset + x < length / 2; x++)
            {
                if (s[offset + x] != s[offset - x + length - 1])
                    return false;
            }

            return true;
        }
    }
}