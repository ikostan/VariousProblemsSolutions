using System;
using System.Text;
using System.Diagnostics;

namespace LongestPalindromicSubstring
{
    class Program
    {
        /*
        #5: Longest Palindromic Substring:

        Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

        Example: 
        Input: "babad", Output: "bab"

        Note: "aba" is also a valid answer.
        
        Example:
        Input: "cbbd", Output: "bb"

        Example:
        Input: "a", Output: "a"

        Example:
        Input: "bb", Output: "bb"

            Src: https://leetcode.com/problems/longest-palindromic-substring/
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Longest Palindromic Substring:\n");

            Program prg = new Program();

            string[] arr = new string[] {
                "a",
                "bb",
                "babad",
                "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"
            };

            foreach (string str in arr)
            {
                Console.WriteLine(prg.LongestPalindrome(str));
            }

            //Console.WriteLine(prg.LongestPalindrome("civilw"));

            Console.ReadKey();
        }

        public string LongestPalindrome(string s)
        {
            StringBuilder str = new StringBuilder("", 1000);

            if (s.Length > 1)
            { 
                
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
            //Debug.WriteLine($"original: {str}, reversed: {rStr}");
            return rStr;
        }

        //End Of Class
    }
}
