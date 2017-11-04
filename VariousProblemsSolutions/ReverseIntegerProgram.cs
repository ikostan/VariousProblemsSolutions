using System;
using System.Diagnostics;

namespace VariousProblemsSolutions
{
    class Program
    {
        /// <summary>
        /// 7. Reverse Integer
        /// Source: https://leetcode.com/problems/reverse-integer/description/
        /// Reverse digits of an integer.
        /// Example1: x = 123, return 321
        /// Example2: x = -123, return -321
        /// Note: The input is assumed to be a 32-bit signed integer.Your function should return 0 when the reversed integer overflows.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            Console.WriteLine(SimpleReverse(321));
            Console.WriteLine(SimpleReverse(-321));

            Console.ReadKey();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int SimpleReverse(int x)
        {

            int result = 0;

            if (x >= Int32.MaxValue || x < Int32.MinValue)
            {
                result = 0;
            }
            else if(x > 0 || x < 0) 
            {
                int tempX = Math.Abs(x);
                string temp = x.ToString();
                char[] arr = temp.ToCharArray();
                Array.Reverse(arr);

                if (tempX > 9)
                {
                    temp = "";

                    foreach (char chr in arr)
                    {
                        temp += chr;
                    }

                    try
                    {
                        if (x > 0)
                        {
                            result = int.Parse(temp);
                        }
                        else
                        {
                            result = int.Parse(String.Format("{0}{1}", '-', temp));
                        }
                    }
                    catch (Exception)
                    {
                        result = 0;
                    }
                }
                else
                {
                    result = x;
                }

            }

            return result;
        }
    }
}
