using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Payroll : Employee
    {

        int id;
        string name;
        string reportingManager;
        string joiningDate;
        int exp;
        double bSalary;
        double da;
        double hra;
        int pf;
        double salary;

        public Payroll()
        {
            count++;
        }

        public Payroll(int id, string name, string reportingManager, string joiningDate, int exp, double bSalary, double da, double hra, int pf)
        {
            count++;
            this.id = id;
            this.name = name;
            this.reportingManager = reportingManager;
            this.joiningDate = joiningDate;
            this.exp = exp;
            this.bSalary = bSalary;
            this.da = da;
            this.hra = hra;
            this.pf = pf;
           
        }

        public int getSalary() {
            if (exp > 10)
            {
                da = (10 / 100) * (this.bSalary);
                hra = (8.5 / 100) * (this.bSalary);
                pf = 6200;
                salary += da + hra + pf;
            }
            else if (exp > 7 && exp < 10)
            {
                da = (7 / 100) * (this.bSalary);
                hra = (6.5 / 100) * (this.bSalary);
                pf = 4100;
                salary += da + hra + pf;
            }
            else if (exp > 5 && exp < 7)
            {
                da = (4.1 / 100) * (this.bSalary);
                hra = (3.8 / 100) * (this.bSalary);
                pf = 1800;
                salary += da + hra + pf;
            }
            else
            {
                da = (1.9 / 100) * (this.bSalary);
                hra = (2.0 / 100) * (this.bSalary);
                pf = 1200;
                salary += da + hra + pf;
            }

            return(int)salary;
        }

        public override string? ToString()
        {
            return id + "\t" +name + "\t" + reportingManager + "\t" + joiningDate + "\t" + exp + "\t" + bSalary + "\t" + da + "\t" + hra + "\t" + pf;
        }
    }
}
