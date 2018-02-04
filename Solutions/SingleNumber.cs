using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class SingleNumber
    {
        public int Execute(int[] nums)
        {
            int i = 0;

            Array.Sort(nums);
            for(i=0;i<nums.Length-1;i=i+2)
            {
                if(nums[i]!=nums[i+1])
                {
                    return nums[i];
                }
            }
            return nums[i];
        }

        public int ExecuteUsingXor(int[] nums)
        {
            int i = 0;
            int result = 0;

            Array.Sort(nums);
            for (i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
