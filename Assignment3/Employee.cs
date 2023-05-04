using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Employee
    {
        public int id  {  set; get; }
        public string Name { set; get; }   
        
        public string dept { set; get; }

        public int salary { set; get; }

        Employee(int id, string name, string dept, int salary)
        {
            this.id = id;
            Name = name;
            this.dept = dept;
            this.salary = salary;
        }

        Employee() { }

        public override string ToString()
        {
            return "Employee: " + id + " " + Name + " " + dept + " " + salary;
        }

        public static void Main() { 
          
              List<Employee> emp = new List<Employee>();
               emp.Add(new Employee(1,"Himanshu","Solutions",15000));
               emp.Add(new Employee(2, "Naman", "Solutions", 15000));
               emp.Add(new Employee(3,"Aman","Solutions",15000)); 
               emp.Add(new Employee(4,"Chaman","HR",15000));
               emp.Add(new Employee(5, "Pawan", "PMO", 15000));
              emp.Add(new Employee(6, "Rohit", "Solutions", 15000));
              emp.Add(new Employee(7, "Mohit", "Solutions", 15000));
              emp.Add(new Employee(8, "King", "PM", 15000));
              emp.Add(new Employee(9, "Raman", "Solutions", 15000));
              emp.Add(new Employee(10, "Pawn", "Testing", 15000));

           

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.id + "\t" + e.Name + "\t" + e.dept + "\t" + e.salary);
            }

             var list1 = (from e in emp where e.salary > 10000 && e.salary <25000
                            select e).ToList();

             list1 = emp.Where( x => x.salary > 10000 && x.salary < 25000).ToList();

            list1 = (from e in emp
                     where e.dept.Contains("HR")
                     select e).ToList();
            list1 = emp.Where(x => x.dept.Contains("HR")).ToList() ;

            list1 = (from e in emp select e).ToList();

            list1 = emp.ToList();

           




        }


    }
}
