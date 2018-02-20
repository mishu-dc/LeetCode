using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Tree
{
    /*Leet Code: https://leetcode.com/problems/diameter-of-binary-tree/description/*/
    public class DiameterOfBinaryTree
    {
        int _max = 0;

        public int Execute(TreeNode root)
        {
            if (root == null) return 0;

            int left = TreeHeight(root.left, 0);
            int right = TreeHeight(root.right, 0);

            _max = left + right > _max ? left + right : _max;

            return _max;
        }

        private int TreeHeight(TreeNode root, int height)
        {
            if (root == null) return 0;

            int left = TreeHeight(root.left, height);
            int right = TreeHeight(root.right, height);

            _max = left + right > _max ? left + right : _max;

            return Math.Max(left, right) + 1;
        }
    }
}
