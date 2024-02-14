using System;

namespace MyLeetCode.FindMedianSortedArrays
{
    public class Solution
    {
        public static void Main()
        {

        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> set = [];

            for (int i = 0; i < nums1.Length; i++)
                set.Add(nums1[i]);

            for (int i = 0; i < nums2.Length; i++)
                set.Add(nums2[i]);

            set.Sort();

            return set.Count switch
            {
                0 => 0,
                _ when set.Count % 2 == 0 => (set[set.Count / 2 - 1] + set[set.Count / 2]) / 2.0,
                _ => set[set.Count / 2]
            };
        }
    }
}