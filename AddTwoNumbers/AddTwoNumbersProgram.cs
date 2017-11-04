using System;
using System.Collections;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    class Program
    {

        /// <summary>
        /// 
        /// 2. Add Two Numbers:
        /// Source: https://leetcode.com/problems/add-two-numbers/description/
        /// You are given two non-empty linked lists representing two non-negative integers. 
        /// The digits are stored in reverse order and each of their nodes contain a single digit. 
        /// Add the two numbers and return it as a linked list.
        /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        /// 
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {
            // Test cases: 
            // [2,4,3] and [5,6,4] ==> [7,0,8]
            // [5] and [5] ==> [0,1]
            // [9] and [9] ==> [8,1]
            // [1,8] and [0] ==> [1,8]

            Console.ReadKey();
        }


        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode a = l1, b = l2, first = new ListNode(0), current = first;
            List<ListNode> values = new List<ListNode>();
            int reminder = 0;

            while (a != null || b != null)
            {
                int sum = ((a != null) ? a.val : 0) + ((b != null) ? b.val : 0) + reminder;

                current.next = new ListNode(((sum >= 10) ? sum % 10 : sum));
                current = current.next;

                if (sum == 10)
                {
                    reminder = 1;
                }
                else if (sum > 10)
                {
                    reminder = sum / 10;
                }
                else
                {
                    reminder = 0;
                }

                a = (a != null) ? a.next : null;
                b = (b != null) ? b.next : null;
            }

            if (reminder > 0)
            {
                current.next = new ListNode(reminder);
                current = current.next;
            }

            return first.next;
        }

        /// <summary>
        ///  Definition for singly-linked list:
        /// </summary>
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

    }
