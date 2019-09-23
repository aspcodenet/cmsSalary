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
            var hourEmployee = new HourEmployee("Stefan", "12345", 100m);
            var sellerEmployee = new SellerEmployee("Josefine", "31",10000);
            var monthlyEmployee = new MonthlyEmployee("Oliver", "312231",5000);
            var e = new ManagerEmployee("Marwan", "3131231");

            var lista = new List<Employee>();
            lista.Add(e);
            lista.Add(hourEmployee);
            lista.Add(sellerEmployee);
            lista.Add(monthlyEmployee);


            foreach(var employee in lista)
            {
                Console.WriteLine($"Löneberäkning för {employee.Name}");
                employee.PrintDescription();
                employee.RunSalary();
            }


        }
    }
}
