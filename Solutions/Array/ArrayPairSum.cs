using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ArrayPairSum
    {
        public int Solution(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
