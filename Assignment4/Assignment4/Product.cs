using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Product
    {

         int pCode;
         string pName;
         int pStock;
       readonly  int pDiscount;
        static  string brand = "Brand";
        const float offerDiscount = 10;
        int pPrice;
        double total;

      public Product() {
           
        }

       public Product(int pCode, string pName, int pStock, int pDiscount, int pPrice)
        {
            this.pCode = pCode;
            this.pName = pName;
            this.pStock = pStock;
            this.pDiscount = pDiscount;
            this.pPrice = pPrice;
        }

        public void takeInput() {

            Console.WriteLine("Enter pCode : ");
            this.pCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pName : ");
            this.pName = Console.ReadLine();
            Console.WriteLine("Enter pStock");
            this.pStock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter pPrice : ");
            this.pPrice = Convert.ToInt32(Console.ReadLine());
          //  totalAmount();

            //Console.WriteLine("Enter pDiscount");
            //this.pDiscount = Convert.ToDecimal(Console.ReadLine());
        }

        public void totalAmount() {

            total = pPrice - (pPrice * offerDiscount)/100;
            Console.WriteLine("Total is : " + total);

        }

        public void displayBill() {

            Console.WriteLine("Your bill is ..........");
            Console.WriteLine("P_Name : " + this.pName);
            Console.WriteLine("Brand : " +brand);
            Console.WriteLine("P_Price : " + this.pPrice);
            Console.WriteLine("P_Discount : " + this.pDiscount);
            Console.WriteLine("P_Stock : " + this.pStock);
            Console.WriteLine("Total Price  : " + this.total);

        }

    }
}
