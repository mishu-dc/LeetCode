
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class PlusOne
    {
        public int[] Execute(int[] digits)
        {
            List<int> items = new List<int>();
            int carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                carry = sum / 10;
                sum = sum % 10;

                items.Add(sum);
            }

            if (carry > 0)
            {
                items.Add(carry);
            }
            items.Reverse();

            return items.ToArray();
        }
    }
}
