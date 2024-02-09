namespace MyLeetCode.LengthOfLongestSubstring
{
    public static class Solution
    {
        public static void Main()
        {

        }

        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> set = []; int max = 0;

            for (int i = 0; i < s.Length;)
            {
                var current = s[i];

                if (set.Contains(current))
                {
                    i -= set.Count - 1;
                    max = Math.Max(max, set.Count);
                    set.Clear();
                }
                else
                {
                    set.Add(current);
                    i++;
                }
            }

            return Math.Max(max, set.Count);
        }
    }
}