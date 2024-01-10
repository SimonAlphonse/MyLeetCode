namespace TwoSum
{
    public static class Solution
    {
        public static void Main()
        {

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int index = 0; index < nums.Length; index++)
            {
                var matchIndex = nums[(index + 1)..].ToList().IndexOf(target - nums[index]);
                if (matchIndex != -1)
                    return [index, matchIndex + index + 1];
            }

            return [];
        }
    }
}