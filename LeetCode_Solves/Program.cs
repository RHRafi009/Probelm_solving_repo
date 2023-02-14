using LeetCode_Solves.Problems;
using LeetCode_Solves.Problems.InterviewProblems;
using System;
using System.Collections.Generic;

namespace LeetCode_Solves
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode root1 = new ListNode(9, 
                new ListNode(9, 
                new ListNode(9, 
                new ListNode(9,
                new ListNode(9,
                new ListNode(9,
                new ListNode(9)))))));
            ListNode root2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));

            ListNode root3 = new AddTwoNumbers().Solution(root1, root2);
            
            while (root3 != null)
            {
                Console.WriteLine(root3.val);
                root3 = root3.next;
            }
        }
    }
}
