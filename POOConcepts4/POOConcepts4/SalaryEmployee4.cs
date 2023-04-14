using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts4
{
    public class SalaryEmployee4 : Employee4
    {
        public decimal Salary4 { get; set; }
        public override decimal GetValueToPay()
       
        {
          return Salary4;
        }

        public override string ToString()
        {
            return $" {base.ToString()}" +
                $"\n\tValue to pay:......... {$"{GetValueToPay():C2}", 18}";
        }
    }
}

