using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Task1
    {

        static void Main(string[] args) {


            // creating directories
            if (!Directory.Exists("C:\\Users\\Himanshur\\Desktop\\Demo"))
            {
                Directory.CreateDirectory("C:\\Users\\Himanshur\\Desktop\\Demo");
            }

            if (!Directory.Exists("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1"))
            {
                Directory.CreateDirectory("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1");
            }

            if (!Directory.Exists("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2"))
            {
                Directory.CreateDirectory("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2");
            }


            // creating the files
            if (!File.Exists("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file1.txt"))
            {

                File.Create("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file1.txt");

            }

            if (!File.Exists("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file2.txt"))
            {
                
                File.Create("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file2.txt");

            }

         
            // writing on the file
            string content = "Hi am writing in the file1";
            
                File.AppendAllText("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file1.txt",content );

            File.AppendAllText("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file2.txt","hello this is file 2...." );

            if (!File.Exists("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2\\file1.txt"))
            {
                File.Copy("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file1.txt", "C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2\\file1.txt");
            }

            /*File.AppendAllText("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo1\\file1.txt", "C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2\\file1.txt");*/

            Console.WriteLine("Get file Name in directory");
            string fileName1 = @"C:\Users\Himanshur\Desktop\Demo\Demo1";
            string[] fileName=Directory.GetFiles(fileName1);
            foreach (string fileName2 in fileName)
            {
                Console.WriteLine(fileName2);
                FileInfo file = new FileInfo(fileName2);
                DateTime dt = file.CreationTime;
                Console.WriteLine("Creation Time: " + dt);
            }

            // delete

            if (File.Exists("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2\\file1.txt"))
            {
                File.Delete("C:\\Users\\Himanshur\\Desktop\\Demo\\Demo2\\file1.txt");
            }

        }

        

    }
}
