using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] inputArr = { 2,7,11,15};
            var result = TwoSum(inputArr, 9);
            Console.WriteLine($"Indexes of two to make 9 are: {result[0]} and {result[1]}");
            Console.WriteLine($"Indexes of two to make 9 are: {result[0]} and {result[1]}");
            Console.WriteLine($"Indexes of two to make 9 are: {result[0]} and {result[1]}");
        }
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> inputNums = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int secondArg = target - nums[i];
                if (inputNums.ContainsKey(secondArg))
                {
                    result[0] = inputNums[secondArg];
                    result[1] = i;
                    return result;
                }
                else
                {
                    inputNums.Add(nums[i], i);
                }
            }
            return null;

        }
    }
}
