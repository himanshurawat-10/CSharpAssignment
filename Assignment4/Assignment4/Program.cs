namespace Assignment4
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.takeInput();
            p1.displayBill();
            p1.totalAmount();
            Console.WriteLine(p1.ToString());

        }
    }

}