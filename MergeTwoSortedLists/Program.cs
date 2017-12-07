using System;

namespace MergeTwoSortedLists
{
    class Program
    {
        /*
         21. Merge Two Sorted Lists

            Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

            Example:

            Input: 1->2->4, 1->3->4
            Output: 1->1->2->3->4->4

          Source: https://leetcode.com/problems/merge-two-sorted-lists/description/   
        */

        /*
         Definition for singly-linked list.
            
            public class ListNode {

                 public int val;
                 public ListNode next;
                 public ListNode(int x) { val = x; }
             }
        */

        static void Main(string[] args)
        {
            Console.WriteLine("21. Merge Two Sorted Lists:\n");

            Program prg = new Program();

            //Test cases: [1,2,4] [1,3,5]

            int[] first = { 1, 2, 4 };
            int[] second = { 1, 3, 5 };

            ListNode start1 = new ListNode(-1);
            ListNode start2 = new ListNode(-1);
            ListNode l1 = start1;
            ListNode l2 = start2;

            for (int i = 0; i < first.Length; i++)
            {
                l1.next = new ListNode(first[i]);
                l1 = l1.next;

                l2.next = new ListNode(second[i]);
                l2 = l2.next;

                System.Diagnostics.Debug.WriteLine($"{l1.val} {l2.val}");
            }

            ListNode a = prg.MergeTwoLists(start1.next, start2.next);

            do
            {
                Console.WriteLine(a.val);
                a = a.next;
            }
            while (a.next != null);
            Console.WriteLine(a.val); //Last one

            Console.ReadKey();
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode first = new ListNode(-1);
            ListNode list = first;

            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else
            {
                while (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        list.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        list.next = l2;
                        l2 = l2.next;
                    }

                    list = list.next;
                    System.Diagnostics.Debug.WriteLine($"Log (list): {list.val}");
                }
            }

            list.next = (l1 == null) ? l2 : l1;

            System.Diagnostics.Debug.WriteLine($"Return (list): {first.next.val}");
            return first.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
