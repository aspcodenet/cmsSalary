using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsSalarySystem
{
    class HourEmployee : Employee
    {
        private decimal nrOfWorkedHours = 0;
        public void SetNumberOfWorkedHours(decimal hours)
        {
            nrOfWorkedHours = hours;
        }
        public HourEmployee(string name, string accountNo, decimal hourlySalary) 
            : base(name, accountNo)
        {
            HourlySalary = hourlySalary;
        }

        public decimal HourlySalary { get; }

        public override void PrintDescription()
        {
            Console.WriteLine($"Vi har räknat på timlön{HourlySalary} och antal timmar{nrOfWorkedHours}");
        }


        public override void RunSalary()
        {
            Console.WriteLine($"Salary: {HourlySalary * nrOfWorkedHours}");
        }

    }
}
