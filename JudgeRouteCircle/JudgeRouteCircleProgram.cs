using System;

namespace JudgeRouteCircle
{
    class JudgeRouteCircleProgram
    {
        /// <summary>
        /// 
        /// 657. Judge Route Circle
        /// Source: https://leetcode.com/problems/judge-route-circle/description/
        /// Initially, there is a Robot at position (0, 0). Given a sequence of its moves, 
        /// judge if this robot makes a circle, which means it moves back to the original place.
        ///The move sequence is represented by a string. And each move is represent by a character.
        ///The valid robot moves are R (Right), L (Left), U (Up) and D (down). 
        ///The output should be true or false representing whether the robot makes a circle.
        ///
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //Test cases: 
            // Input: "UD" ==> Output: true
            // Input: "LL" ==> Output: false

            Console.WriteLine(JudgeCircle("UD"));
            Console.WriteLine(JudgeCircle("LL"));

            Console.ReadKey();
        }

        public static bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;

            foreach (char chr in moves)
            {
                if (chr == 'U')
                {
                    y++;
                }
                else if (chr == 'D')
                {
                    y--;
                }
                else if (chr == 'L')
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }

            if (x == 0 && y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
