using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5
{
    internal class Assign5
    {

        static void Main(string[] args)
        { 
        
            List<OnContract> onContracts = new List<OnContract>();
            onContracts.Add(new OnContract(1, "Name1", "Manager1", "15 May 2023", 3, 25000));
            onContracts.Add(new OnContract(2, "Name2", "Manager1", "5 Jun 2023", 4, 15000));
            onContracts.Add(new OnContract(3, "Name3", "Manager2", "25 May 2023", 5, 35000));
            onContracts.Add(new OnContract(4, "Name4", "Manager1", "1 Mar 2023", 3, 20000));
            onContracts.Add(new OnContract(5, "Name5", "Manager3", "15 Apr 2023", 3, 45000));

            Console.WriteLine( "Id"+ "\t" + "Name" + "\t" + "ReportingManger" + "\t" + "ContractDate" + "\t" + "Duration" + "\t" + "Charges");
            foreach ( var emp in onContracts)
            {
                Console.WriteLine(emp);
            }

            List<Payroll> payrolls = new List<Payroll>(); 

            payrolls.Add(new Payroll());

            Employee e = new Employee();

            Console.WriteLine(e.getEmpCount());

           

        }

    }
}
