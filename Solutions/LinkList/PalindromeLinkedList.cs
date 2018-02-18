using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            int length = 0;
            int mid = 0;
            int count = 1;

            ListNode temp = head;
            ListNode midPoint = null;

            while (temp != null)
            {
                temp = temp.next;
                length++;
            }

            mid = (length / 2 + 1);

            midPoint = head;
            while (count < mid)
            {
                midPoint = midPoint.next;
                count++;
            }

            midPoint = ReverseList(midPoint);

            count = 0;
            while (count < mid)
            {
                if (head.val != midPoint.val)
                    return false;
                count++;
                head = head.next;
                midPoint = midPoint.next;
            }

            return true;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode reversed = null;
            ListNode temp = null;
            while (head != null)
            {
                temp = new ListNode(head.val);
                if (reversed != null)
                {
                    temp.next = reversed;
                }
                reversed = temp;
                head = head.next;
            }
            return reversed;
        }
    }
}
