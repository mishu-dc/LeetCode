using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LinkedListCicle
    {
        public ListNode DetectCycle(ListNode head)
        {
            ListNode first = head;
            ListNode slow = head;

            while (first != null && first.next != null)
            {
                slow = slow.next;
                first = first.next.next;

                if (first == slow)
                {
                    ListNode slow2 = head;
                    while (slow != slow2)
                    {
                        slow = slow.next;
                        slow2 = slow2.next;
                    }
                    return slow;
                }
            }
            return null;
        }
    }
}
