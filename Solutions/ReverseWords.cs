using System;
using System.Text;


namespace Solutions
{
    public class ReverseWords
    {
        public string Execute(string s)
        {
            string[] words = s.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                string reverse = ReverseString(word);
                builder.Append(reverse);
                builder.Append(" ");
            }
            string result = builder.ToString();
            return result.Substring(0, result.Length - 1);
        }

        private string ReverseString(string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] characters = word.ToCharArray();
            for(int i=characters.Length-1;i>=0;i--)
            {
                sb.Append(characters[i]);
            }
            return sb.ToString();
        }
    }
}
