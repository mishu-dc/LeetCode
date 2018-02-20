using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    /*Leetcode: https://leetcode.com/problems/find-leaves-of-binary-tree/description/*/
    public class FindLeavesOfBinaryTree
    {
        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            List<IList<int>> leafs = new List<IList<int>>();

            while (root != null)
            {
                List<int> nodes = new List<int>();
                if (IsLeaf(root, nodes))
                {
                    root = null;
                }
                leafs.Add(nodes);
            }

            return leafs;
        }

        private bool IsLeaf(TreeNode root, List<int> nodes)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null)
            {
                nodes.Add(root.val);
                return true;
            }

            if (IsLeaf(root.left, nodes))
            {
                root.left = null;
                return true;
            }

            if (IsLeaf(root.right, nodes))
            {
                root.right = null;
                return true;
            }

            return false;
        }
    }
}
