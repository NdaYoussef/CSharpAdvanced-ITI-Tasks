namespace Day3P1
{
    internal class Program
    {
        //  public static Func<float, bool> FilterDel = s => s > 1000;
        public static Func<float, bool> filterDelEmployee;

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

            Employee employee2 = new Employee()
            {
                Name = "Youssef",
                Salary = 1800.0f
            };

            Employee employee3 = new Employee()
            {
                Name = "Ali",
                Salary = 3800.0f
            };
            //  Console.WriteLine($"Company Budget before Increasement: {company.Budget}");


            //company.Add(employee);
            //company.Add(employee2);
            //employee.IncreaseSalary(200.0f);
            //employee2.IncreaseSalary(300.0f);

            //Console.WriteLine($"first employee: {employee.Name}, Salary after increasement: {employee.Salary}");
            //Console.WriteLine($"second employee: {employee2.Name}, Salary after increasement: {employee2.Salary}");

            //Console.WriteLine($"Company Budget after Increasement: {company.Budget}");



            //List<Employee> employees = new List<Employee>
            //    {
            //        new Employee { Name = "nda", Salary = 5000 },
            //        new Employee { Name = "sara", Salary = 7000 },
            //        new Employee { Name = "ali", Salary = 4000 },
            //    };
            company.Employees.Add(new Employee { Name = "nda", Salary = 5000 });
            company.Employees.Add(new Employee { Name = "sara", Salary = 7000 });
            company.Employees.Add(new Employee { Name = "ali", Salary = 4000 });

            List<Employee> highestSalary =company.FilterEmployee((s => s > 5000));
            foreach(var emp in  highestSalary)
            {
                Console.WriteLine($"Emp Name: {emp.Name}, Emp Salary: {emp.Salary}");
            }


        }
    }
}
