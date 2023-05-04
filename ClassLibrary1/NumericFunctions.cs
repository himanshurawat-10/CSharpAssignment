using System;
namespace CommonFunctions
{
    public class NumericFunctions
    {

      public  int AddNum(params int[] nums)
        {
            return nums.Sum();
        }

        public int Subtract(int ? n1, int ? n2)
        {
            n1 =n1 ?? 10;
            n2 =n2 ?? 10;
           return n1.Value - n2.Value; 
        }

        public int Multiply(int ? n1, int ? n2)
        {
            n1 = n1 ?? 10;
            n2 = n2 ?? 10;
            return n1.Value * n2.Value;
        }

        public int Divide(int ? n1, int ? n2)
        {
            n1 = n1 ?? 10;
            n2 = n2 ?? 10;
            return n1.Value / n2.Value; 
        }

        public int FindMax(params int[] nums)
        {
            return nums.Max();
        }

        public int FindMin(params int[] nums)
        { 
            return nums.Min();
        }

        public bool CheckEven(int ? n)
        { 
            n = n ?? 10;
           return (n.Value % 2 == 0);
        }

        public bool CheckOdd(int ? n)
        {
            n = n ?? 10;
            return (n.Value % 2 == 1);
        }

        public bool CheckPrime(int ? n)
        {
            n = n ?? 10;
           
            if( n.Value == 1 ) { 
                return true;
            }

            for( int i = 2; i * i <= n; i++ )
            {
                if( n.Value % i == 0 )
                {
                    return false;
                }
            }

            return true;
        }



    }
}