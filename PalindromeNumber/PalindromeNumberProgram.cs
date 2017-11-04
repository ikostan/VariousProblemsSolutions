using System;
using System.Diagnostics;

namespace PalindromeNumber
{
    class PalindromeNumberProgram
    {
        /// <summary>
        /// 
        /// 9. Palindrome Number
        /// Source: https://leetcode.com/problems/palindrome-number/description/
        /// A palindromic number or numeral palindrome is a number that remains the same when its digits are reversed. 
        /// Determine whether an integer is a palindrome. Do this without extra space.
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //Testcases: -2147483648, -2147447412;

            //Console.WriteLine(IsPalindrome(1));
            //Console.WriteLine(IsPalindrome(11));
            //Console.WriteLine(IsPalindrome(121));
            //Console.WriteLine(IsPalindrome(1221));
            //Console.WriteLine(IsPalindrome(125621));
            //Console.WriteLine(IsPalindrome(-2147483648));

            Console.WriteLine(IsPalindrome(-2147447412));

            Console.ReadKey();
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int reversedX = 0;
            int temp = x;

            while (temp != 0)
            {
                int remainder = 0;

                temp = Math.DivRem(temp, 10, out remainder);

                try
                {
                    reversedX = reversedX * 10 + remainder;
                    Debug.WriteLine($"reversedX: {reversedX}, remainder: {remainder}, temp: {temp}");
                }
                catch (System.OverflowException)
                {
                    return false;
                }

            }

            if (x == reversedX)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
