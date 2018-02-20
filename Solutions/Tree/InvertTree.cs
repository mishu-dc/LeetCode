using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Tree
{
    /*Leet Code: https://leetcode.com/submissions/detail/141569927/ */

    public class InvertTree
    {
        public TreeNode Invert(TreeNode root)
        {
            if (root == null) return null;

            TreeNode invertedtree = new TreeNode(root.val);

            invertedtree.left = Invert(root.right);
            invertedtree.right = Invert(root.left);

            return invertedtree;
        }
    }
}
