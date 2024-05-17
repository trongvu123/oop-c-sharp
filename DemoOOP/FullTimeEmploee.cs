using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    public class FullTimeEmploee : Employee
    {
        public FullTimeEmploee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return paymentPerHour * 8;
        }
        public override string ToString()
        {
            return  $"FullTimeEmployee{{name='{name}', paymentPerHour={paymentPerHour}, salary={calculateSalary()}}}"; ;
        }


    }
}
