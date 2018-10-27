using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> nums_checked = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
                if (nums_checked.ContainsKey(target - nums[i]))
                    return new int[] { nums_checked[target - nums[i]], i };
                else if (!nums_checked.ContainsKey(nums[i])) nums_checked.Add(nums[i], i);
            return new int[] { };
        } 
    }
}

