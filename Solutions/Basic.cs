using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override bool Equals(object obj)
        {
            ListNode node = (ListNode)obj;
            ListNode self = this;
            do
            {
                if (node == null && self ==null) return true;
                if (node == null && self != null) return false;
                if (node != null && self == null) return false;
                if (node.val != self.val) return false;

                node = node.next;
                self = self.next;
            } while (true);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
