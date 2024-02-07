using System;
using System.Reflection;

namespace MyLeetCode.LengthOfLongestSubstring
{
    public static class Solution
    {
        public static void Main()
        {

        }

        public static int LengthOfLongestSubstring(string s)
        {
            int start = 0, end = 0;

            for (int index = 1; index < s.Length; index++)
            {
                if (s[start..index].Contains(s[index]))
                {
                    end = index;
                }
            }

            return end - start;
        }
    }
}