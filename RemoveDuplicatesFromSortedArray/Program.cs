using System;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        /*
         * 26. Remove Duplicates from Sorted Array
         Given a sorted array, remove the duplicates in-place such that each element appear only once and return the new length.

        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        Example:

        Given nums = [1,1,2],

        Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
        It doesn't matter what you leave beyond the new length.

            Source: https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Remove Duplicates from Sorted Array:\n");

            Program prg = new Program();
            int[] nums = { 1, 1, 2 }; //should return length = 2, with the first two elements of nums being 1 and 2 respectively.
            Console.WriteLine(prg.RemoveDuplicates(nums));

            Console.ReadKey();
        }

        public int RemoveDuplicates(int[] nums)
        {
            int index = 0;

            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == nums.Length - 1 || nums[i] != nums[i + 1])
                    {
                        nums[index] = nums[i];
                        index++;
                    }
                }
            }

            return index;
        }

        //End of class
    }
}
