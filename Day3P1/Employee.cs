using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3P1
{
    internal class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }

        public event Action<Employee> SalaryChanged;

        public void IncreaseSalary(float amount)
        {
                //salary = 100 
                //amount = 200
                //salary+=amount 
            
            Salary += amount;
            Console.WriteLine($"salary: {Salary} increased with amount: {amount}");
            //3- Notify company with event 
            SalaryChanged.Invoke(this);

        }

    }
}
