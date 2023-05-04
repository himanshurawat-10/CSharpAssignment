using CommonFunctions;

namespace CommonFunctions_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            NumericFunctions numericFunctions = new NumericFunctions();

            Console.WriteLine(numericFunctions.AddNum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            Console.WriteLine(numericFunctions.CheckPrime(11));
            Console.WriteLine(numericFunctions.FindMin(10, 2, 4, 5, 0, -1, -99, 100));
            Console.WriteLine(numericFunctions.FindMax(10, 1, 3, 4, 5, 100, 1000, 2000, 2, 4, 5));
            Console.WriteLine(numericFunctions.CheckEven(101));
            Console.WriteLine(numericFunctions.CheckOdd(103));

            Console.WriteLine("List of Evne no...");
            List<int> allEven = numericFunctions.AllEven(10, 20);
            foreach (int i in allEven) Console.WriteLine(i);

            Console.WriteLine("List of Odd no...");
            List<int> allOdd = numericFunctions.AllOdd(10, 20);
            foreach (int i in allOdd) Console.WriteLine(i);

            Console.WriteLine("List of Prime no...");
            List<int> allPrime = numericFunctions.AllPrime(10, 20);
            foreach (int i in allPrime) Console.WriteLine(i);

            Console.WriteLine(numericFunctions.TableOfNumber(10));

            Console.WriteLine(numericFunctions.TableInGivenRange(2,5));

            int rev = numericFunctions.ReverseNum(12345);
            Console.WriteLine(rev);

            StringFunctions stringFunctions = new StringFunctions();
            Console.WriteLine(stringFunctions.RemoveSpaces("Hello   I   am   Deepak"));

            Console.WriteLine(stringFunctions.CountSubstring("Hello this a lazy dog this dog is lazy","Lazy dog"));

        }
    }
}