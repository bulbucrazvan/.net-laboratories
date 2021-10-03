using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Employee
    {
        Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }

        public Employee(string FirstName, string LastName, DateTime StartDate, DateTime EndDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsActive()
        {
            return EndDate.CompareTo(DateTime.Now) >= 0 && StartDate.CompareTo(DateTime.Now) <= 0;
        }
        public abstract string Salutation();
    }
}
