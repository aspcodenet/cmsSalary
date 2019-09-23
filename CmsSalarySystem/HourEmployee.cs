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
    }
}
