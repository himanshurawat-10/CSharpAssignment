using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class OnContract : Employee
    {

       public int id  { get; set; }
       public  string name { get; set; }
       public string reportingManager { get; set; }

        public string contractDate { get; set; }

        public int duration { get; set; }

      public  int charges { get; set; }
       
        public OnContract(int id, string name, string reportingManager, string contractDate, int duration, int charges)
        {
            this.id = id;
            this.name = name;
            this.reportingManager = reportingManager;
            this.contractDate = contractDate;
            this.duration = duration;
            this.charges = charges;
            count++;
        }

        public OnContract()
        {
            count++;
        }

        public override string? ToString()
        {
            return id + "\t" + name + "\t" + reportingManager + "\t" + contractDate + "\t" + duration + "\t" + charges;
        }



    }
}
