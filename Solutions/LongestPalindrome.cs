using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LongestPalindrome
    {
        public int Execute(string s)
        {
            int result = 0;
            int carry = 0;

            char[] items = s.ToCharArray();
            int[] counts = new int[256];

            for(int i = 0;i<counts.Length;i++)
            {
                counts[i] = 0;
            }

            foreach(char item in items)
            {
                counts[item]++;
            }

            for(int i=0;i< counts.Length;i++)
            {
                result += counts[i] - counts[i] % 2;
                if (counts[i] % 2 != 0)
                    carry=1;
            }
            

            return result+carry;
        }
    }
}
