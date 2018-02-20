using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Tree
{
    /*Leet Code: https://leetcode.com/submissions/detail/141565149/*/
    public class BinaryTreeRightSideView
    {
        List<int> rightView = new List<int>();

        public IList<int> RightSideView(TreeNode root)
        {
            recure(root, 0);
            return rightView;
        }

        private void recure(TreeNode root, int depth)
        {
            if (root == null) return;

            if (rightView.Count <= depth)
            {
                rightView.Add(root.val);
            }
            else
            {
                rightView[depth] = root.val;
            }

            recure(root.left, depth + 1);
            recure(root.right, depth + 1);
        }
    }
}
