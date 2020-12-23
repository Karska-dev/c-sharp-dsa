using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] inputArr = { 3,3,6,15};
            int target = 9;
            var result = TwoSum(inputArr, target);
            //var result = BruteForce(inputArr, target);
            Console.WriteLine($"Indexes of two to make {target} are: {result[0]} and {result[1]}");
        }
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> inputNums = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int secondArg = target - nums[i];
                if (inputNums.ContainsKey(secondArg))
                {
                    return new int[] { inputNums[secondArg], i };
                }
                else if (!inputNums.ContainsKey(nums[i]))
                {
                    inputNums.Add(nums[i], i);
                }
            }
            return null;

        }
        static int[] BruteForce(int[] nums, int target)
        {
            int[] result = new int[] { };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return result;
        }
      
    }
}
