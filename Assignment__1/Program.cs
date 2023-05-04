
namespace Assignment__1
{


    internal class Program
    {
        public static void Main(string[] args)
        {
            //Q1.
            Console.WriteLine("Hello Message!");

            //Q2.
             int add;
              int sub;
             int pro; 
             int que;
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("num1 : " +num1 + "\n" + "num2 : " +num2 + "\n");
            calc(num1, num2,out add,out sub,out pro,out que);
            Console.WriteLine(add );
            Console.WriteLine(sub);
            Console.WriteLine(pro );
            Console.WriteLine(que);

            // Q3...
            Console.WriteLine("Enter your choice......");
            Console.WriteLine("Enter 1 for addition \n" +
                "Enter 2 for subtraction \n" + "Enter 3 for product \n"+
                "Enter 4 for quotient \n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:Console.WriteLine("Addition of "+num1 +" and " +num2 + " = " +num1 + num2); break;
                    case 2:Console.WriteLine("Subtraction of " + num1 + " and " + num2 + " = "+ (num2 - num1)); break;
                    case 3:Console.WriteLine("Product of " + num1 + " and " + num2 + " = " + num1 * num2); break;
                    case 4:Console.WriteLine("Quotient of " + num1 + " and " + num2 + " = " + num2 /num1 ); break;
                    default: Console.WriteLine("Wrong Choice...");
                    break;
            }

            Console.WriteLine();
            //Q4...
            for (int i = 0; i < 10; i++)
            { 
               Console.WriteLine("Himanshu Rawat");
            }

            //Q5 
            Console.WriteLine("\n Even no. b/w 1-10 \n");
            checkEven();

            //Q6
            Console.WriteLine("\n Odd no. b/w 50-7 \n");
            checkOdd();

            //Q7
            Console.WriteLine("Table of : ");
                int tabl = Convert.ToInt32(Console.ReadLine());
            printTable(tabl);

            //Q8
            Console.WriteLine("Number from 100 - 5 gap of 3..");
            displayNum();

            //Q9 
            int a= 10 , b = 20;
            Console.Write("Display in same line" + a + "\t" + b);

            //Q10
            Console.WriteLine("\n display in next line \n" +a +  "\n" + b);

        }

        //Q2 function ...
        public static void calc(int num1, int num2, out int add, out int sub, out int pro, out int que)
        {
           add = num1 + num2;
           sub = num2 - num1;
            pro = num1 * num2;
           que = num2 / num1;
        }

        //Q5
        private static void checkEven()
        {
            for( int i = 1; i <= 10 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "\t");
                }
            }
        }

        //Q6..
        private static void checkOdd()
        {
            for (int i = 50; i >= 7; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Q7..
        private static void printTable(int tabl)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(tabl + "X" + i + " = " + i * tabl);
            }
        }

        //Q8
        private static void displayNum()
        {
            for (int i = 100; i >= 5; i -= 3)
            { 
                Console.WriteLine(i);
            }
        }



    }

}