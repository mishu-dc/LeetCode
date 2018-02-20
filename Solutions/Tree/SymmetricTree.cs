using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    /*https://leetcode.com/problems/symmetric-tree/description/*/
    public class SymmetricTree
    {
        public bool IsSymmetricRecursive(TreeNode root)
        {
            if (root == null) return true;
            return recure(root.left, root.right);
        }

        //Pending
        public bool IsSymmetricIterative(TreeNode root)
        {
            return false;
        }

        public bool recure(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == right;
            if (left.val != right.val)
                return false;
            return recure(left.left, right.right) && recure(left.right, right.left);
        }
    }
}
