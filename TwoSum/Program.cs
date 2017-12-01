using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        /*
        #1 Two Sum:
        Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Example:
        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].

        Src: https://leetcode.com/problems/two-sum/description/
        */

        static void Main(string[] args)
        {

        }

        public int[] TwoSum(int[] nums, int target)
        {
            int i = 0, b;
            int[] result = new int[2];
            bool isDone = false;

            while (!isDone)
            {
                for (b = i + 1; b < nums.Count(); b++)
                {
                    if (nums[i] + nums[b] == target)
                    {
                        result[0] = i;
                        result[1] = b;
                        isDone = true;
                        break;
                    }
                }

                i++;
            }

            return result;
        }
    }
}
