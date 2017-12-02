using System;
using System.Text;
using System.Diagnostics;

namespace LongestPalindromicSubstring
{
    class Program
    {
        /*
        
        Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

        Example: 
        Input: "babad", Output: "bab"

        Note: "aba" is also a valid answer.
        
        Example:
        Input: "cbbd", Output: "bb"

        Example:
        Input: "a", Output: "a"

        */

        static void Main(string[] args)
        {
            Console.WriteLine("Longest Palindromic Substring:\n");

            Program prg = new Program();
            Console.WriteLine(prg.LongestPalindrome("babad"));

            Console.ReadKey();
        }

        public string LongestPalindrome(string s)
        {
            StringBuilder str = new StringBuilder("", 1000);

            if (s.Length > 1)
            {
                for (int a = 0; a < s.Length - 1; a++)
                {
                    for (int i = 1; i < s.Length; i++)
                    {
                        if (a + i <= s.Length)
                        {
                            string value = s.Substring(a, i);

                            if (string.Compare(
                                    value,
                                    ReverseString(value),
                                    StringComparison.CurrentCultureIgnoreCase) == 0)
                            {
                                if (value.Length > str.Length)
                                {
                                    Debug.WriteLine($"original str: {str.ToString()}");
                                    str.Remove(0, str.Length);
                                    Debug.WriteLine($"deleted str: {str.ToString()}");
                                    str.Insert(0, value);
                                    Debug.WriteLine($"new str: {str.ToString()}");
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                return s;
            }

            return str.ToString();
        }

        /// <summary>
        /// Reverse string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ReverseString(string str)
        {
            char[] reverse = str.ToCharArray();
            Array.Reverse(reverse);
            string rStr = new string(reverse);
            Debug.WriteLine($"original: {str}, reversed: {rStr}");
            return rStr;
        }

        //End Of Class
    }
}
