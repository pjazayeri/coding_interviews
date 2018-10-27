using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {2, 7, 11, 15 };
            var target = 9;
            var result = Solution.TwoSum(nums, target);

            Console.WriteLine(result.ToString());
        }
    }
}
