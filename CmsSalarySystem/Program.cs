using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsSalarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Stefan", "12345");
            var hourEmployee = new HourEmployee("Stefan", "12345", 100m);
        }
    }
}
