using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            char[] values = s.Trim().ToLower().ToCharArray();

            int i = 0, j = values.Length - 1;

            while (i < j)
            {
                while (i < values.Length && !char.IsLetterOrDigit(values[i])) i++;
                while (j >= 0 && !char.IsLetterOrDigit(values[j])) j--;

                if (i > j) return true;

                if (values[i] != values[j]) return false;
                i++;
                j--;
            }
            
            return true;
        }
    }
}
