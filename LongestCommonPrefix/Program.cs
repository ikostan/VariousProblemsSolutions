using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

namespace LongestCommonPrefix
{
    class Program
    {
        /*
         14. Longest Common Prefix

            Write a function to find the longest common prefix string amongst an array of strings.

            Src: https://leetcode.com/problems/longest-common-prefix/description/
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Longest Common Prefix:\n");

            Program prg = new Program();

            //Test cases:
            List<string[]> strList = new List<string[]>();
            strList.Add(new string[] { "" });               //Returns empty string
            strList.Add(new string[] { "a", "b" });         //Returns empty string
            strList.Add(new string[] { "a", "a", "b" });    //Returns empty string
            strList.Add(new string[] { "c", "c"});          //Returns "c"
            strList.Add(new string[] { "ca", "c" });        //Returns empty string
            strList.Add(new string[] { "aa", "a" });        //Returns "a"

            //Main method execution:
            foreach (string[] item in strList)
            {
                Console.WriteLine(prg.LongestCommonPrefix(item));
            }                

            Console.ReadKey();
        }

        /// <summary>
        /// Finds the longest common prefix string amongst an array of strings
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder prefix = new StringBuilder("");

            if (strs.Length == 0)
            {
                return "";
            }
            else if (strs.Length == 1)
            {
                return strs[0];
            }
            else
            {
                
            }

            return prefix.ToString();
        }
    }
}
