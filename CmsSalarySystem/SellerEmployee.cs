using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsSalarySystem
{
    class SellerEmployee : MonthlyEmployee
    {
        private decimal soldFor = 0;
        public void SetSoldForAmount(decimal value)
        {
            soldFor = value;
        }
        public SellerEmployee(string name, string accountNo, decimal monthlySalary) 
            : base(name, accountNo, monthlySalary)
        {
        }

        public override void PrintDescription()
        {
            base.PrintDescription();
            Console.WriteLine($"och adderat provision {soldFor} * 0.01");
        }


        public override void RunSalary()
        {
            Console.WriteLine($"Salary: {MonthlySalary + (soldFor * 0.01m)}");
        }


    }
}
