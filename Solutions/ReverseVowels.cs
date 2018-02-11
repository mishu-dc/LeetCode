using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ReverseVowels
    {
        public string Execute(string s)
        {
            string vowels = "aeiouAEIOU";
            char[] characters = s.ToCharArray();

            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                while (start < end && vowels.IndexOf(characters[start]) == -1) start++;
                while (end > start && vowels.IndexOf(characters[end]) == -1) end--;

                if (start < end)
                {
                    char temp = characters[start];
                    characters[start] = characters[end];
                    characters[end] = temp;
                }
                start++;
                end--;
            }

            return new string(characters);
        }
    }
}
