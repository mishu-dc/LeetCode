using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class LongestSubstring
    {
        public int Execute(string s)
        {
            int max = 0;
            List<int> x = new List<int>();
            
            Dictionary<char, bool> dict = new Dictionary<char, bool>();
            char[] chars = s.ToCharArray();
            for (int i = 0,j = 0; i<chars.Length && j<chars.Length;)
            {
                if(dict.ContainsKey(chars[j]))
                {
                    dict.Remove(chars[i]);
                    i++;
                }
                else
                {
                    dict.Add(chars[j], true);
                    j++;
                }
                int length = j - i;
                max = max < length ? length : max;
            }
            
            return max;
        }
    }
}
