using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        /*
        #3: Longest Substring Without Repeating Characters

        Given a string, find the length of the longest substring without repeating characters.
        
        Examples:

        Given "abcabcbb", the answer is "abc", which the length is 3.

        Given "bbbbb", the answer is "b", with the length of 1.

        Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
          
        Src: https://leetcode.com/problems/longest-substring-without-repeating-characters/description/   
        
            Test cases: "abcabcbb", "pwwkew"
        */

        static void Main(string[] args)
        {

        }

        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            HashSet<char> unique = new HashSet<char>();

            foreach (char chr in s)
            {
                if (!unique.Contains(chr))
                {
                    unique.Add(chr);
                    length++;
                }
                else
                {
                    break;
                }
            }

            return length;
        }
    }
}
