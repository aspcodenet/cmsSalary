using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsSalarySystem
{
    class MonthlyEmployee : Employee
    {
        public MonthlyEmployee(string name, string accountNo, decimal monthlySalary) 
            : base(name, accountNo)
        {
            MonthlySalary = monthlySalary;
        }

        public decimal MonthlySalary { get; }

        public override void PrintDescription()
        {
            base.PrintDescription();
            Console.WriteLine($"Vi har bara tagit din månadslön {MonthlySalary}");
        }

        public override void RunSalary()
        {
            Console.WriteLine($"Salary: {MonthlySalary}");
        }

    }
}
