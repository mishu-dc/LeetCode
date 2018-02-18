using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            long number = x;
            number = Math.Abs(number);
            long hfactor = 1;
            long lfactor = 10;

            while (number / hfactor > 0)
            {
                hfactor = hfactor * 10;
            }

            hfactor = hfactor / 10;

            number = x;
            number = Math.Abs(number);
            while (hfactor > 0)
            {
                if (number % lfactor != number / hfactor)
                    return false;
                number = number % hfactor;
                number = number / lfactor;
                hfactor = hfactor / 100;
            }

            return true;
        }
    }
}
