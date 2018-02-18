using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class FindAllNumbers
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> results = new List<int>();

            Array.Sort(nums);

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!BinarySearch(nums, i))
                {
                    results.Add(i);
                }
            }

            return results;
        }

        public bool BinarySearch(int[]  nums, int key)
        {
            int left = 0, right = nums.Length - 1, mid;

            while (left <= right)
            {
                mid = (int)((left + right) / 2);
                if (key == nums[mid])
                {
                    return true;
                }
                else if (key > nums[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }
    }
}
