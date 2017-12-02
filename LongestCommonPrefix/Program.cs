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
            strList.Add(new string[] { "" });                                   //Returns empty string
            strList.Add(new string[] { "c", "c" });                             //Returns "c"
            strList.Add(new string[] { "aa", "aa" });                           //Returns "aa"
            strList.Add(new string[] { "a", "b" });                             //Returns empty string
            strList.Add(new string[] { "a", "a", "b" });                        //Returns empty string
            strList.Add(new string[] { "ca", "a" });                            //Returns empty string
            strList.Add(new string[] { "ca", "c" });                            //Returns "c"
            strList.Add(new string[] { "aa", "a" });                            //Returns "a"
            strList.Add(new string[] { "c", "acc", "ccc" });                    //Returns empty string
            strList.Add(new string[] { "aac", "acab", "aa", "abba", "aa" });    //Returns "a"

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
            List<bool> lst = new List<bool>();

            if (strs.Length == 0)
            {
                return prefix.ToString();
            }
            else if (strs.Length == 1)
            {
                return strs[0];
            }
            else
            {
                int min = GetShortestStringIndex(strs); //Shortest string id
                Debug.WriteLine($"min indx: {min}");
                string pfx = strs[min];

                for (int i = 0; i < strs.Length; i++)
                {
                    bool isExist = false;

                    if (i != min)
                    {
                        for (int b = pfx.Length; b > 0; b--)
                        {
                            string a = strs[i].Substring(0, b);
                            string c = pfx.Substring(0, b);

                            Debug.WriteLine($"a: {a}, c: {c}, b: {b}");

                            if (a == c)
                            {
                                isExist = true;

                                prefix.Remove(0, prefix.Length);
                                prefix.Insert(0, pfx.Substring(0, b));
                                pfx = prefix.ToString();

                                break;
                            }
                        }

                        lst.Add(isExist);
                    }
                }
            }

            if (lst.Contains(false))
            {
                return "";
            }
            else
            {
                return prefix.ToString();
            }
        }


        /// <summary>
        /// Get id of the shortest string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int GetShortestStringIndex(string[] str)
        {
            int min = 0;
            int minLength = str[min].Length;

            for (int i = 0; i < str.Length; i++)
            {
                if (minLength > str[i].Length)
                {
                    min = i;
                    minLength = str[i].Length;
                }
            }

            return min;
        }

        //End of class
    }
}
