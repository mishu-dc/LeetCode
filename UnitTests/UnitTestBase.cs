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

            for (int i = 0; i < values.Length; i++)
            {
                if (head == null)
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

        public TreeNode GetTreeNode(int?[] values)
        {
            int count = 0;
            if (values == null || values.Length == 0) return null;

            TreeNode root = new TreeNode(values[count++].Value);

            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (count < values.Length && nodes.Count > 0)
            {
                TreeNode node = nodes.Dequeue();
                if (values[count] != null)
                {
                    node.left = new TreeNode(values[count++].Value);
                    nodes.Enqueue(node.left);
                }

                if (count < values.Length && values[count] != null)
                {
                    node.right = new TreeNode(values[count++].Value);
                    nodes.Enqueue(node.right);
                }
            }

            return root;

        }
    }
}
