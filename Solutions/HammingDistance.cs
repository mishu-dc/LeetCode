using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class HammingDistance
    {
        public int Solution(int x, int y)
        {
            int count = 0;
            int i = 0;

            char[] smaller = GetBits(x < y ? x : y);
            char[] bigger = GetBits(x > y ? x : y);

            for (i = 0; i < smaller.Length; i++)
            {
                if (smaller[i] != bigger[i])
                    count++;
            }

            while (i < bigger.Length)
            {
                if (bigger[i] != '0')
                    count++;
                i++;
            }


            return count;
        }

        public char[] GetBits(int number)
        {
            string bits = string.Empty;

            while (number > 0)
            {
                bits += number % 2;
                number /= 2;
            }

            return bits.ToCharArray();
        }
    }
}
