using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.b
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Salary {  get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
