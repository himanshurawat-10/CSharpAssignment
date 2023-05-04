
namespace Assignment2
{
    internal class Assign_2
    {
        public  static void Main(string[] args)
        {

            //Q1.. sum and avg 
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            printSumAndAvg(arr1);

            //Q2.. sum of 3X3 matrix
            int[,] arr2 = { { 1, 2, 3}, { 4, 5, 6 } , { 7, 8, 9 } };
            calcSum(arr2);

            //Q3.. max ele
            int[] arr3 = { 1, 2, 5, 7, 8, 10, 12, 3, 2, 5 };
            Console.WriteLine("max element : "+arr3.Max());

            //Q4.. col sum
            int[,] arr4 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            colSum(arr4 );

            //Q5.. row sum
            rowSum(arr4);

        }

        

        //Q1
        private static void printSumAndAvg(int[] arr1)
        {
             int sum = 0;
           
            for( int i = 0 ; i < arr1.Length; i++ )
            {
                sum += arr1[i];
            }
            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Average is : " + (sum / arr1.Length ));

        }

        //Q2..
        private static void calcSum(int[,] arr2)
        {
            int sum = 0;
            for (int i = 0; i < arr2.GetLength(0); i++)
            { 
              for( int j = 0; j < arr2.GetLength(1); j++ ) 
                {
                    sum += arr2[i,j]; 
                }
            }

            Console.WriteLine("Sum : " + sum);
        }

        //Q4..
        private static void colSum(int[,] arr4)
        {
            

            for (int i = 0; i < arr4.GetLength(1); i++)
            {
                int colSum = 0;

                for (int j = 0; j < arr4.GetLength(0); j++)
                { 
                  colSum += arr4[j,i];
                }
                Console.WriteLine("Col Sum : " + i + " " + colSum);
            }

        }

        //Q5..
        private static void rowSum(int[,] arr5)
        {
           

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    rowSum += arr5[i, j];
                }
                Console.WriteLine("Row Sum : "+ i + " " + rowSum);
            }

        }


    }

}