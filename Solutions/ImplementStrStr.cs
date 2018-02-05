using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            char[] hayStackChars = haystack.ToCharArray();
            char[] needleChars = needle.ToCharArray();

            for(int i=0; ;i++)
            {
                for(int j=0; ;j++)
                {
                    if (j == needle.Length) return i;
                    if (i + j == hayStackChars.Length) return -1;
                    if (needleChars[j] != hayStackChars[i + j]) break;
                }
            }
        }
    }
}
