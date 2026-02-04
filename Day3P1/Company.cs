using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3P1
{
    internal class Company
    {
        public string Name { get; set; }
        public float Budget { get; set; }

        //public Company()
        //{
            
        //}
        public List<Employee> Employees { get; set; }   = new List<Employee>();

        //2- declare callback method 
        public void BudgetNotification(Employee employee)
        {
            Budget -= employee.Salary;
           foreach (Employee emp in Employees)
            {
                Console.WriteLine($"Employee: {emp.Name} has an increased salary with value: {emp.Salary}, leads to decrease in company's budget with value: {Budget}");
            }
        }
    }
}
