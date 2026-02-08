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


        //public void BudgetNotification(Employee employee)
        //{
        //    Budget -= employee.Salary;
        //   foreach (Employee emp in Employees)
        //    {
        //        Console.WriteLine($"Employee: {emp.Name} has an increased salary with value: {emp.Salary}, leads to decrease in company's budget with value: {Budget}");
        //    }
        //}

        //2 subscriber declare callback method 
        public void DecreaseBudget( float amount)
        {
            this.Budget -= amount;
        }


        //3- subscribe 
        public void Add(Employee employee)
        {
            Employees.Add(employee);

            employee.SalaryChanged += this.DecreaseBudget;

        }

        public  List<Employee> FilterEmployee( Func<float, bool> filterDelEmployee)
        {
            List<Employee> list = new List<Employee>();

            foreach (var emp in Employees)
            {
                if (filterDelEmployee(emp.Salary))
                    list.Add(emp);
            }
            return list;
        }
    }
}
