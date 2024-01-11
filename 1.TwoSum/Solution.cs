using System;

namespace MyLeetCode.TwoSum
{
    public static partial class Solution
    {
        public static void Main()
        {

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                        return [i, j];
                }
            }

            return [];
        }
    }
}