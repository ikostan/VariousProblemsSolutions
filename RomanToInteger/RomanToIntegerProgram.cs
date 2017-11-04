using System;

namespace RomanToInteger
{
    class RomanToIntegerProgram
    {
        /// <summary>
        /// 
        /// 13. Roman to Integer
        /// Source: https://leetcode.com/problems/roman-to-integer/description/
        /// How to Read Roman Numerals: https://www.youtube.com/watch?v=49oWYxExWKE
        /// Given a roman numeral, convert it to an integer.
        /// Input is guaranteed to be within the range from 1 to 3999.
        ///
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //Test cases: "DCXXI" = 621, "MCMXCVI" = 1996, "MCMLXIX" = 1969;

            Console.WriteLine(RomanToInt("DCXXI"));
            Console.WriteLine(RomanToInt("MCMXCVI"));
            Console.WriteLine(RomanToInt("MCMLXIX"));

            Console.ReadKey();
        }


        private static int RomanToInt(string str)
        {
            int sum = 0;
            char[] chrArr = str.ToCharArray();

            for (int i = 0; i < chrArr.Length; i++)
            {
                if (i == 0 && chrArr[i] == 'M')
                {
                    sum = ConvertRomanToInt(chrArr[i]);
                }
                else if (i + 1 < chrArr.Length && ConvertRomanToInt(chrArr[i]) < ConvertRomanToInt(chrArr[i + 1]))
                {
                    sum += ConvertRomanToInt(chrArr[i + 1]) - ConvertRomanToInt(chrArr[i]);
                    i++;
                }
                else
                {
                    sum += ConvertRomanToInt(chrArr[i]);
                }
            }

            return sum;
        }

        private static int ConvertRomanToInt(char chr)
        {
            int result = 0;

            switch (chr)
            {
                case 'I':
                    result = 1;
                    break;
                case 'V':
                    result = 5;
                    break;
                case 'X':
                    result = 10;
                    break;
                case 'L':
                    result = 50;
                    break;
                case 'C':
                    result = 100;
                    break;
                case 'D':
                    result = 500;
                    break;
                case 'M':
                    result = 1000;
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
