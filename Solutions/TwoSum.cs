using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class TwoSum
    {
        public int[] Execute(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = (-nums[i] + target);
                if (dict.ContainsKey(rem) && dict[rem] != i)
                {
                    res[0] = i;
                    res[1] = dict[rem];
                    break;
                }
            }

            return res;
        }
    }
}
