using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    public class PartTimeEmployee : Employee
    {
        
        public int workingHhours {  get; set; }
        public PartTimeEmployee(string name, int paymentPerHour,int workingHhours) : base(name, paymentPerHour)
        {
            this.workingHhours = workingHhours;
        }

        public override int calculateSalary()
        {
            return workingHhours*base.paymentPerHour;
        }

        public override string ToString()
        {
            return $"PartTimeEmployee{{name='{name}', paymentPerHour={paymentPerHour}, workingHours={workingHhours}, salary={calculateSalary()}}}";
        }
    }
}
