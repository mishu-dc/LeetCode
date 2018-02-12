using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class RemoveNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            List<int> lists = new List<int>();
            ListNode tail = null;

            while (head != null)
            {
                lists.Add(head.val);
                head = head.next;
            }

            if (lists.Count >= n)
            {
                lists.RemoveAt(lists.Count - n);
            }
            else
            {
                lists.Clear();
            }

            foreach (int val in lists)
            {
                if (head == null)
                {
                    head = new ListNode(val);
                    tail = head;
                }
                else
                {
                    tail.next = new ListNode(val);
                    tail = tail.next;
                }
            }

            return head;
        }

        public ListNode RemoveNthNodeFromEndOptimized(ListNode head, int n)
        {
            int count = 0;
            ListNode slow = head;
            ListNode fast = head;

            while (fast!=null)
            {
                if (count <= n)
                {
                    fast = fast.next;
                    count++;
                }
                else
                {
                    fast = fast.next;
                    slow = slow.next;
                }
            }
            if (count > n)
            {
                slow.next = slow.next.next;
            }
            else
            {
                head = head.next;
            }

            return head;
        }
    }
}
