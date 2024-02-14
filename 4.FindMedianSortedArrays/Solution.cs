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
            HashSet<int> set = [];

            for (int i = 0; i < nums1.Length; i++)
                set.Add(nums1[i]);

            for (int i = 0; i < nums2.Length; i++)
                set.Add(nums2[i]);

            if (set.Count % 2 == 0)
                return 1.0 * (set.Skip(set.Count / 2).First() + set.Skip(set.Count / 2 + 1).First()) / 2;
            else
                return 1.0 * set.Skip(set.Count / 2 + 1).First();
        }
    }
}