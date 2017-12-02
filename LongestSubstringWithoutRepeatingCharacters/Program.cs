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
        
            Test cases: "abcabcbb", "pwwkew", "c", "au", "dvdf"
        */

        static void Main(string[] args)
        {
            Program prg = new Program();
            Console.WriteLine(prg.LengthOfLongestSubstring("dvdf"));
            Console.ReadKey();
        }

        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            int index = 0;
            HashSet<char> unique = new HashSet<char>();
            char[] chrSet = s.ToCharArray();


            while (index < s.Length)
            {
                for (int i = index; i < s.Length; i++)
                {
                    if (!unique.Contains(chrSet[i]))
                    {
                        unique.Add(chrSet[i]);

                        if (unique.Count() > length)
                        {
                            length = unique.Count();
                        }
                    }
                    else
                    {
                        unique.Clear();
                        break;
                    }
                }

                index++;
                Debug.WriteLine($"index: {index}, length: {length}");
            }

            return length;
        }

        //End Of Class
    }
}
