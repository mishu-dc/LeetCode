using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class SelfDividingNumbers
    {
        public IList<int> Solution(int left, int right)
        {
            List<int> results = new List<int>();
            for (int i = left; i <= right; i++)
            {
                if (i.ToString().Contains("0")) continue;
                if (IsSelfDividingNumber(i))
                {
                    results.Add(i);
                }
            }

            return results;
        }

        private bool IsSelfDividingNumber(int num)
        {
            char[] digits = num.ToString().ToCharArray();
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '0') return false;
                if (num % (digits[i] - '0') == 0) return false;
                int digit = Convert.ToInt32(digits[i].ToString());
                if (num % digit != 0) return false;
            }

            return true;
        }
    }
}
