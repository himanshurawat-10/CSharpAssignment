using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Employee
    {
        int id;
        string name;
        string reportingManager;
        static public int count = 0;

       public int getEmpCount() {
            return count;
        }

    }
}
