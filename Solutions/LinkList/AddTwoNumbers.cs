using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class AddTwoNumbers
    {
        public ListNode Execute(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode head = null;
            ListNode tail = null;

            while(l1!=null || l2!=null)
            {
                if (head == null)
                {
                    head = new ListNode(0);
                    tail = head;
                }
                else
                {
                    tail.next = new ListNode(carry);
                    tail = tail.next;
                }

                tail.val += l1 != null ? l1.val : 0;
                tail.val += l2 != null ? l2.val : 0;

                carry = tail.val / 10;
                tail.val = tail.val % 10;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }

            if (carry > 0)
            {
                tail.next = new ListNode(carry);
            }

            return head;
        }
    }
}
