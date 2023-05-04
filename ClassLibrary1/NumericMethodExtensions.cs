using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public static class NumericMethodExtensions
    {
        static NumericFunctions numericFunctions;
         
        public static List<int> AllEven(this NumericFunctions numericFunctions, int start, int end)
        {
            List<int> result = new List<int>();
             for( int i = start; i <= end;i++)
            {
                if (i % 2 == 0)
                {
                   result.Add(i);
                }
            }
             return result;
        }

        public static List<int> AllOdd(this NumericFunctions numericFunctions, int start, int end)
        {
            List<int> result = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static List<int> AllPrime(this NumericFunctions numericFunctions, int start, int end)
        {
            List<int> result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (numericFunctions.CheckPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static String TableOfNumber(this NumericFunctions numericFunctions, int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                sb.Append(num + " * " + i + " = " + num * i + "\n");
            }
            return sb.ToString();
        }
        public static string TableInGivenRange(this NumericFunctions numberFunctions, int start, int end)
        {
            StringBuilder sb = new StringBuilder();



            for (int num = start; num <= end; num++)
            {

                for (int i = 1; i <= 10; i++)
                {
                    sb.Append(num + " * " + i + " = " + num * i + "\n");
                }
                sb.Append("\n");



            }
            return sb.ToString();
        }

        public static int ReverseNum(this NumericFunctions numericFunctions,int n)
        {
          /*  string s = n.ToString();
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            string ans = chars.ToString();
            return Convert.ToInt32(s);*/

            int pow = 0;
            int temp = n;
            while (temp != 0)
            {
                int r = temp % 10;
                pow++;
                temp = temp / 10;
            }
            pow--;
            int ans = 0;
            while (n != 0)
            {
                int r = n % 10;
                ans += r * (int)Math.Pow(10, pow);
                pow--;
                n = n / 10;

            }

            return ans;
        }

    }
}
