using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class TwoSum2
    {
        //O(n log n) runtime , O(1) space
        public int[] TwoSumByBinarySearch(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = numbers[i];
                int j = binarySearch(numbers, target - x, i + 1);
                if (j != -1)
                {
                    return new int[] { i + 1, j + 1 };
                }
            }
            throw new Exception("No solution exists");
        }

        //O(n) runtime , O(1) space
        public int[] TwoSumFaster(int[] numbers, int target)
        {
            for(int i =0, j=numbers.Length-1;i<numbers.Length && j>=0;)
            {
                int sum = numbers[i] + numbers[j];
                if (sum > target)
                {
                    j--;
                }
                else if (sum < target)
                {
                    i++;
                }
                else
                {
                    return new int[] { i + 1, j + 1 };
                }
            }
            throw new Exception("No solution exists");
        }

        public int binarySearch(int[] numbers, int target, int start)
        {
            int l = start;
            int h = numbers.Length - 1;
            int m = 0;

            while (l < h)
            {
                m = (l + h) / 2;
                if (numbers[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    h = m;
                }
            }
            
            return (l == h && numbers[l] == target) ? l : -1;
        }
    }
}
