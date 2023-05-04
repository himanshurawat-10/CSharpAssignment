using System.IO;
using System;
using System.Text;



namespace Assignment7
{
    internal class Task2
    {
        public static void Main(string[] args)
        {

            FileStream fs = new FileStream("C:\\Users\\Himanshur\\Desktop\\Demo\\Task2\\file.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);



            ////Add contents to file
            writer.WriteLine("Hello");
            writer.WriteLine("Hi");
            writer.Close();
            fs.Close();



            ////Append contents to file



            fs = new FileStream("C:\\Users\\Himanshur\\Desktop\\Demo\\Task2\\file.txt", FileMode.Append);
            StreamWriter write = new StreamWriter(fs);
            write.WriteLine("Append");
            write.Close();
            fs.Close();



            //// Dislay All contents together



            fs = new FileStream("C:\\Users\\Himanshur\\Desktop\\Demo\\Task2\\file.txt", FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            Console.WriteLine(read.ReadToEnd());
            //// Display Content one by one



            fs = new FileStream("C:\\Users\\Himanshur\\Desktop\\Demo\\Task2\\file.txt", FileMode.Open, FileAccess.Read);
            StreamReader read2 = new StreamReader("C:\\Users\\Himanshur\\Desktop\\Demo\\Task2\\file.txt");
            string line = read2.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = read2.ReadLine();
            }




        }
    }
}