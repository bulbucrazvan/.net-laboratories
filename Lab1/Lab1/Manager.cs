using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Manager : Employee
    {
        public Manager(string FirstName, string LastName, DateTime StartDate, DateTime EndDate) : base(FirstName, LastName, StartDate, EndDate) { }
        public override string Salutation()
        {
            return "Hello, manager " + this.GetFullName();
        }
    }
}
