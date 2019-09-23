using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsSalarySystem
{
    class Employee
    {
        public Employee(string name, string accountNo)
        {
            Name = name;
            AccountNo = accountNo;
        }

        public string Name { get; }
        public string AccountNo { get; }

        public virtual void RunSalary()
        {

        }
    }
}
