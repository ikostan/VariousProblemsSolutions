using System;
using System.Diagnostics;

namespace StringToInteger
{
    class StringToIntegerProgram
    {

        /// <summary>
        ///  
        /// 8. String to Integer(atoi)
        /// Source: https://leetcode.com/problems/string-to-integer-atoi/description/
        /// 
        /// Implement atoi to convert a string to an integer.
        /// Hint: Carefully consider all possible input cases.If you want a challenge, 
        /// please do not see below and ask yourself what are the possible input cases.
        /// Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). 
        /// You are responsible to gather all the input requirements up front.
        ///
        /// spoilers alert...click to show requirements for atoi.
        /// Requirements for atoi:
        /// The function first discards as many whitespace characters as necessary until the first non-whitespace character is found.Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
        /// The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
        /// If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.
        /// If no valid conversion could be performed, a zero value is returned.If the correct value is out of the range of representable values, INT_MAX (2147483647) or INT_MIN(-2147483648) is returned.
        ///
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //Test cases: "  -0012a42", "", "1", "-1", "+1", "-2147483648", "2147483648", "-2147483649";

            MyAtoi("2147483648");

            Console.ReadKey();
        }

        public static int MyAtoi(string str)
        {
            int result = 0;

            str = str.Trim();
            char[] chrArr = str.ToCharArray();
            string temp = "";
            bool isNegative = false;

            for (int i = 0; i < chrArr.Length; i++)
            {
                if (i == 0 && (chrArr[i] == '-' || chrArr[i] == '+'))
                {
                    if (chrArr[i] == '-')
                    {
                        isNegative = true;
                        temp = "-";
                    }
                    
                    continue;
                }
                else
                {
                    try
                    {
                        result = int.Parse((temp += chrArr[i]));
                        Debug.WriteLine($"temp: {temp}, result: {result}");
                    }
                    catch (System.OverflowException) {

                        if (isNegative)
                        {
                            result = -2147483648;
                        }
                        else
                        {
                            result = 2147483647;
                        }    
                        
                        break;
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            //if (prefix == "-")
            //{
            //    result = result * -1;
            //}

            Debug.WriteLine($"Final: {result}");
            return result;
        }
    }
}
