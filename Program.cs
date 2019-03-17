using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.b
{
    class Program
    {
        static void Main(string[] args)
        {

            // Employee employee = new Employee("Vukshin", "Obradovikj");
            // employee.PrintInfo();

            SalesPerson salesPerson = new SalesPerson("Vukashin", "Obradovikj", 1000);
            salesPerson.AddSuccessRevenue(5000);

            Console.WriteLine(salesPerson.GetSalary());

            Manager manager = new Manager("Vukashin", "Obradovikj", 2000);
            manager.AddBonus(1000);
            Console.WriteLine(manager.GetSalary());
        }
    }
}
