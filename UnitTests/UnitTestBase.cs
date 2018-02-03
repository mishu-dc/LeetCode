using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solutions;

namespace UnitTests
{
    public class UnitTestBase
    {
        public ListNode GetListNode(int[] values)
        {
            ListNode head = null;
            ListNode tail = null;

            if (values == null) return null;

            for(int i=0;i<values.Length;i++)
            {
                if(head==null)
                {
                    head = new ListNode(values[i]);
                    tail = head;
                }
                else
                {
                    tail.next = new ListNode(values[i]);
                    tail = tail.next;
                }
            }

            return head;
        }
    }
}
