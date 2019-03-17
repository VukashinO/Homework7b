using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.b
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }


        public Manager(string firstName, string lastName, double salary) 
            : base(firstName, lastName)
        {
            Role = Role.Manager;
            Salary = salary;
        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            double parent = base.GetSalary();
            return  parent += Bonus;
        }
    }
}
