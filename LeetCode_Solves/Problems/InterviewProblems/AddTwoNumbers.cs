using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Solves.Problems.InterviewProblems
{
    // Problem link - https://leetcode.com/problems/add-two-numbers/

    //Definition for singly-linked list.
    public class ListNode {
          public int val;
          public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }
 
    public class AddTwoNumbers
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            int carry = 0;
            bool isRootPopulated = false;

            ListNode rootNode = new ListNode();
            ListNode nextNode = new ListNode();

            while (l1 != null || l2 != null || carry > 0)
            {
                int sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                l1 = l1?.next;
                l2 = l2?.next;

                if (sum > 9)
                {
                    carry = sum / 10;   
                    sum %= 10;
                }
                else
                {
                    carry = 0;
                }

                if (!isRootPopulated)
                {
                    rootNode.val = sum;
                    isRootPopulated = true;
                }
                else if (isRootPopulated && rootNode.next == null)
                {
                    nextNode = new ListNode(sum);
                    rootNode.next = nextNode;
                }
                else
                {
                    ListNode tempNode = new ListNode(sum);
                    nextNode.next = tempNode;
                    nextNode = tempNode;
                }
            }

            return rootNode;
        }
    }
}
