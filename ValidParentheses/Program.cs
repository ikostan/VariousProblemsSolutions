using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        /*
        20. Valid Parentheses

            Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.

            Src: https://leetcode.com/problems/valid-parentheses/description/
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Valid Parentheses:\n");

            Program prg = new Program();

            List<string> collection = new List<string>();

            foreach (string item in collection)
            {
                Console.WriteLine(prg.IsValid(item));
            }
            
            Console.ReadLine();
        }

        public bool IsValid(string s)
        {
            bool isValid = false;

            return isValid;
        }
    }
}
