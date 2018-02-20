using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Tree
{
    /*LeetCode: https://leetcode.com/problems/merge-two-binary-trees/description/*/
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode merged = recure(t1, t2);
            return merged;
        }

        private TreeNode recure(TreeNode t1, TreeNode t2)
        {
            TreeNode mergedNode = null;
            int mergedValue = 0;
            if (t1 == null && t2 == null)
            {
                return null;
            }
            if (t1 != null && t2 != null)
            {
                mergedValue = t1.val + t2.val;
            }
            else if (t1 != null && t2 == null)
            {
                mergedValue = t1.val;
            }
            else if (t1 == null && t2 != null)
            {
                mergedValue = t2.val;
            }

            mergedNode = new TreeNode(mergedValue);
            mergedNode.left = recure(t1 != null ? t1.left : null, t2 != null ? t2.left : null);
            mergedNode.right = recure(t1 != null ? t1.right : null, t2 != null ? t2.right : null);

            return mergedNode;
        }
    }
}
