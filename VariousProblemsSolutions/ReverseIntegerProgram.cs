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
            //Test cases:
            //SimpleReverseTester();
            ReverseTester();

            Console.ReadKey();
        }

        private static void SimpleReverseTester() {

            //Test cases:
            Console.WriteLine(SimpleReverse(0));
            Console.WriteLine(SimpleReverse(1));
            Console.WriteLine(SimpleReverse(-1));
            Console.WriteLine(SimpleReverse(321));
            Console.WriteLine(SimpleReverse(-321));
            Console.WriteLine(SimpleReverse(-2147483648));
            Console.WriteLine(SimpleReverse(2147483647));
            Console.WriteLine(SimpleReverse(Int32.MaxValue));
            Console.WriteLine(SimpleReverse(Int32.MinValue));
        }

        private static void ReverseTester()
        {

            //Test cases:
            Console.WriteLine(Reverse(0));
            Console.WriteLine(Reverse(1));
            Console.WriteLine(Reverse(-1));
            Console.WriteLine(Reverse(321));
            Console.WriteLine(Reverse(-321));
            Console.WriteLine(Reverse(-2147483648));
            Console.WriteLine(Reverse(2147483647));
            Console.WriteLine(Reverse(Int32.MaxValue));
            Console.WriteLine(Reverse(Int32.MinValue));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Reverse(int x) {

            int result = 0;

            while (x != 0)
            {
                int remaind = 0;

                //Quotient: a result obtained by dividing one quantity by another.
                x = Math.DivRem(x, 10, out remaind);              

                try
                {
                    result = checked(result * 10 + remaind);
                    Debug.WriteLine($"x: {x}, remaind: {remaind}, result: {result}");
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int SimpleReverse(int x)
        {

            int result = 0;

            if (x >= Int32.MaxValue || x <= Int32.MinValue)
            {
                //System.Overflow
                result = 0;
            }
            else if (x > 0 || x < 0)
            {
                int tempX;

                if (x < 0)
                {
                    tempX = x * -1;
                }
                else
                {
                    tempX = x;
                }

                Debug.WriteLine($"tempX: {tempX}");

                string temp = tempX.ToString();
                Debug.WriteLine($"temp: {temp}");

                char[] arr = temp.ToCharArray();
                Array.Reverse(arr);

                if (tempX > 9)
                {
                    temp = "";

                    foreach (char chr in arr)
                    {
                        temp += chr;
                    }

                    Debug.WriteLine($"temp: {temp}");

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
                else {
                    result = x;
                }
            }
            else
            {
                result = x;
            }          

            return result;
        }
    }
}
