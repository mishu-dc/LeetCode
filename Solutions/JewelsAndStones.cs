using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class JewelsAndStones
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            
            char[] jewelChars = J.ToCharArray();
            char[] stones = S.ToCharArray();
            bool[] jewels = new bool[256];

            foreach (char j in jewelChars)
                jewels[j]=true;

            foreach (char s in stones)
                if (jewels[s])
                    count++;
            
            return count;
        }


        public int NumJewelsInStonesOptimized(string J, string S)
        {
            int count = 0;
            char[] stones = S.ToCharArray();

            foreach (char s in stones)
                if (J.Contains(s))
                    count++;

            return count;
        }
    }
}
