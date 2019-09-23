using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsSalarySystem
{
    class ManagerEmployee : Employee
    {
        public ManagerEmployee(string name, string accountNo) : base(name, accountNo)
        {
        }

        public override void PrintDescription()
        {
            throw new NotImplementedException();
        }

        public override void RunSalary()
        {
            throw new NotImplementedException();
        }
    }
}
