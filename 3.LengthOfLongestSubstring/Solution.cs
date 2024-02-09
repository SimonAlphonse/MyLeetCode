namespace MyLeetCode.LengthOfLongestSubstring
{
    public class Solution
    {
        public static void Main()
        {

        }

        public int LengthOfLongestSubstring(string s)
        {
            return s.Length == 0 ? 0 : Enumerable.Range(0, s.Length).AsParallel().Max(index => LengthOfLongestSubString(s, index));
        }

        private int LengthOfLongestSubString(string s, int index)
        {
            HashSet<char> set = [];

            for (int i = index; i < s.Length; i++)
            {
                var current = s[i];

                if (set.Contains(current))
                    return set.Count;
                else
                    set.Add(current);
            }

            return set.Count;
        }
    }
}