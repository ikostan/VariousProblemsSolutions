﻿using System;

namespace AddTwoNumbers
{
    class Program
    {

        /// <summary>
        /// 2. Add Two Numbers
        /// Source: https://leetcode.com/problems/add-two-numbers/description/
        /// You are given two non-empty linked lists representing two non-negative integers. 
        /// The digits are stored in reverse order and each of their nodes contain a single digit. 
        /// Add the two numbers and return it as a linked list.
        /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {


            Console.ReadKey();
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultListNode = null;



            return resultListNode;
        }
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
