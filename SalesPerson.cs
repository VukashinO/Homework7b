using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.b
{
    public class SalesPerson : Employee
    {

        private double SuccessSaleRevenue {  get; set; }

        public SalesPerson(string firstName, string lastName, double successSaleRevenue)
            : base(firstName, lastName)
        {
            Role = Role.Sales;
            Salary = 500;
            SuccessSaleRevenue = successSaleRevenue;
        }

        public void AddSuccessRevenue(double value)
        {
             SuccessSaleRevenue += value;
        }

        public override double GetSalary()
        {
            double parent = base.GetSalary();

            if(SuccessSaleRevenue <= 2000)
            {
                 return parent += 500;
            }
            else if(SuccessSaleRevenue <= 5000)
            {
                return parent += 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return parent += 1500;
            }
            else
            {
                return parent;
            }
        }
    }
}
