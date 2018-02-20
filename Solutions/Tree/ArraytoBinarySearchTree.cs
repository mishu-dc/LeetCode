using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    /*LeetCode: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/*/
    public class ArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode root = null;

            root = recure(nums, 0, nums.Length - 1);

            return root;
        }

        private TreeNode recure(int[] nums, int l, int h)
        {
            if (l > h)
            {
                return null;
            }

            int m = (l + h) / 2;
            TreeNode node = new TreeNode(nums[m]);

            node.left = recure(nums, l, m - 1);

            node.right = recure(nums, m + 1, h);

            return node;
        }
    }
}
