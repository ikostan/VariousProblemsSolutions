using System;
using System.Collections;
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
            collection.Add("[");            //False
            collection.Add("()");           //True
            collection.Add("()[]{}");       //True
            collection.Add("(]");           //False
            collection.Add("([)]");         //False
            collection.Add("([])");         //True

            foreach (string item in collection)
            {
                Console.WriteLine($"Testing: {item}\n");
                Console.WriteLine(prg.IsValid(item));
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public bool IsValid(string s)
        {
            Stack <char> chars = new Stack<char>();

            if (s.Length % 2 != 0)
            {
                return false;
            }
            else
            {
                foreach (char item in s)
                {
                    if (item == '(')
                    {
                        chars.Push(')');
                        WriteLog(chars, '(');
                    }
                    else if (item == '{')
                    {
                        chars.Push('}');
                        WriteLog(chars, '{');
                    }
                    else if (item == '[')
                    {
                        chars.Push(']');
                        WriteLog(chars, '[');
                    }
                    else if (chars.Count == 0 || chars.Pop() != item)
                    {
                        WriteLog(chars);
                        return false;
                    }
                }
            }

            if (chars.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void WriteLog(Stack<char> stk, char a = ' ')
        {
            string arr = new string(stk.ToArray());

            char b = ' ';

            if (a == '(')
            {
                b = ')';
            }
            else if (a == '{')
            {
                b = '}';
            }
            else if (a == '[')
            {
                b = ']';
            }

            Console.WriteLine($"Read: {a} Write: {b} Stack: {arr}");
        }

        //End of class
    }
}
