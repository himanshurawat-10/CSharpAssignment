using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CommonFunctions
{
    public class StringFunctions
    {

        public int FindCharacters(string str)
        {
            int count = 0;
            foreach (char ch in str)
            {
                if (ch != ' ')
                {
                    count++;
                }
            }
            return count;
        }



        public bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }



        public string ReverseSentence(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }



        public string ConvertUpperCase(string str)
        {
            return str.ToUpper();
        }



        public string ConvertLowerCase(string str)
        {
            return str.ToLower();
        }



        public string CombineTwoSentence(string str1, string str2)
        {
            string ans = String.Concat(str1, str2);
            return ans;
        }



        public string RemoveSpaces(string str)
        {

            return Regex.Replace(str, @"\s+", " ");

        }



        public int CountWords(string str)
        {
            int count = 1;
            foreach (char ch in str)
            {
                if (ch == ' ') count++;
            }
            return count;
        }

        public bool SearchSubstring(string str)
        {
            return str.Contains(str);

        }

        public int CountSubstring(String str, String substring)
        {

            string[] chars = str.ToLower().Split(substring.ToLower());

            for( int i = 0; i < chars.Length; i++ )
            {
                Console.Write(chars[i] +"\t");
               
            }

            return str.ToLower().Split(substring.ToLower()).Length - 1;
        
        }

    }
}
