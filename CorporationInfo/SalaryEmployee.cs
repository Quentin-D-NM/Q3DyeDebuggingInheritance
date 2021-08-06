using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        //to call the overloaded class constructor this is the proper way to do it. 
        public SalaryEmployee() : this("", "", 30000.0M) 
        {
        }

        public SalaryEmployee(string firstName, string lastName, decimal salary, string phone = "TBD", string email = "TBD") :
            base(firstName,lastName, phone, email)
        {
            Salary = salary; //You need to add this to the Salary Employee as the base class does not have salary property. 
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + Salary + " per year";
            }
        }

        public override decimal Pay(int start, int end)
        {
            const int  payPeriodsPerYear = 24;
            decimal pay = Salary * (end - start) / payPeriodsPerYear;
            return pay;
        }

        public override string ToString() //use the override keyword here
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
