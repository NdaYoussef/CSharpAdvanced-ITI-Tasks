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

        //public delegate bool FilterDel(float salary);

        //   public event Action<float> EmpIncreasedSalaryDel ;
        //1- publisher creates event 
        public delegate void  EmpSalaryDel (float s);
        public event EmpSalaryDel SalaryChanged;


        //4- Notification
        public void IncreaseSalary(float amount)
        {
                //salary = 100 
                //amount = 200
                //salary+=amount 
            
            this.Salary += amount;
           // Console.WriteLine($"salary: {Salary} of Employee: {Name} has been increased with amount: {amount}");
            //3- Notify company with event 
            this.SalaryChanged(amount);

        }

        #region Task2
    


       
        #endregion




    }
}
