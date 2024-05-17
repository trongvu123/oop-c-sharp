using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    public abstract class Employee : IEmployee
    {
        protected string name { get; set; }
        protected int paymentPerHour { get; set; }

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();

        public string getName() => name;

        public override string ToString()=> $"Employee{{name='{name}', paymentPerHour={paymentPerHour}}}";

    }

}
