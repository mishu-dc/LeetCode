using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class AddTwoNumbers2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            Stack<int> fList = new Stack<int>();
            Stack<int> sList = new Stack<int>();

            while (l1 != null)
            {
                fList.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                sList.Push(l2.val);
                l2 = l2.next;
            }

            ListNode head = null, tail = null;

            do
            {
                if (fList.Count() == 0 && sList.Count() == 0) break;

                int x = fList.Count > 0 ? fList.Pop() : 0;
                int y = sList.Count > 0 ? sList.Pop() : 0;

                int sum = x + y + carry;
                carry = sum / 10;
                sum = sum % 10;

                if (tail == null)
                {
                    tail = new ListNode(sum);
                    head = tail;
                }
                else
                {
                    head = new ListNode(sum);
                    head.next = tail;
                    tail = head;
                }

            } while (true);

            if (carry > 0)
            {
                head = new ListNode(carry);
                head.next = tail;
                tail = head;
            }

            return head;
        }
    }
}
