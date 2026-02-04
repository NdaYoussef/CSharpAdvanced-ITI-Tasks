namespace Day3P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company()
            {
                Name = "Company1",
                Budget = 10000.0f
            };

            Employee employee = new Employee()
            {
                Name = "Nda",
                Salary = 2200.0f
            };

            //add new employee to list of Employess in company
            company.Employees.Add(employee);

            //process of salary changed 
            employee.SalaryChanged += company.BudgetNotification;

            employee.IncreaseSalary(200.0f);

        }
    }
}
