using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public static class SampleData
    {
        // Departments
        public static List<Department> Departments = new List<Department>
    {
        new Department { DeptId = 1, DeptName = "Computer Science", Address = "Building A" },
        new Department { DeptId = 2, DeptName = "Mathematics", Address = "Building B" },
        new Department { DeptId = 3, DeptName = "Physics", Address = "Building C" },
        new Department { DeptId = 4, DeptName = "Engineering", Address = "Building D" }
    };

        // Subjects
        public static List<Subject> Subjects = new List<Subject>
    {
        new Subject { SubjectId = 1, SubjectName = "Programming" },
        new Subject { SubjectId = 2, SubjectName = "Database" },
        new Subject { SubjectId = 3, SubjectName = "Networking" },
        new Subject { SubjectId = 4, SubjectName = "Algorithms" },
        new Subject { SubjectId = 5, SubjectName = "Web Development" }
    };

        // Courses
        public static List<Course> Courses = new List<Course>
    {
        new Course { CourseId = 1, CourseName = "C# Programming", Hours = 60, DeptId = 1, SubjectId = 1 },
        new Course { CourseId = 2, CourseName = "SQL Fundamentals", Hours = 50, DeptId = 1, SubjectId = 2 },
        new Course { CourseId = 3, CourseName = "Advanced C#", Hours = 70, DeptId = 1, SubjectId = 1 },
        new Course { CourseId = 4, CourseName = "Network Security", Hours = 55, DeptId = 3, SubjectId = 3 },
        new Course { CourseId = 5, CourseName = "Data Structures", Hours = 65, DeptId = 1, SubjectId = 4 },
        new Course { CourseId = 6, CourseName = "ASP.NET Core", Hours = 80, DeptId = 1, SubjectId = 5 },
        new Course { CourseId = 7, CourseName = "Linear Algebra", Hours = 45, DeptId = 2, SubjectId = 4 },
        new Course { CourseId = 8, CourseName = "Cloud Computing", Hours = 58, DeptId = 4, SubjectId = 3 },
        new Course { CourseId = 9, CourseName = "JavaScript", Hours = 62, DeptId = 1, SubjectId = 5 },
        new Course { CourseId = 10, CourseName = "Database Design", Hours = 56, DeptId = 1, SubjectId = 2 }
    };

        // Employees
        public static List<Employee> Employees = new List<Employee>
    {
        new Employee { EmpId = 1, EmpName = "Ahmed Ali", Salary = 25000, DeptId = 1 },
        new Employee { EmpId = 2, EmpName = "Sara Mohamed", Salary = 18000, DeptId = 1 },
        new Employee { EmpId = 3, EmpName = "Omar Hassan", Salary = 30000, DeptId = 2 },
        new Employee { EmpId = 4, EmpName = "Fatma Ibrahim", Salary = 22000, DeptId = 3 },
        new Employee { EmpId = 5, EmpName = "Khaled Youssef", Salary = 15000, DeptId = 1 },
        new Employee { EmpId = 6, EmpName = "Mona Ahmed", Salary = 28000, DeptId = 2 },
        new Employee { EmpId = 7, EmpName = "Hassan Mahmoud", Salary = 19000, DeptId = 4 },
        new Employee { EmpId = 8, EmpName = "Nour Khalil", Salary = 35000, DeptId = 3 }
    };

        // Products
        public static List<Product> Products = new List<Product>
    {
        new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics", UnitPrice = 1200, UnitsInStock = 15 },
        new Product { ProductId = 2, ProductName = "Mouse", Category = "Electronics", UnitPrice = 25, UnitsInStock = 0 },
        new Product { ProductId = 3, ProductName = "Keyboard", Category = "Electronics", UnitPrice = 45, UnitsInStock = 30 },
        new Product { ProductId = 4, ProductName = "Monitor", Category = "Electronics", UnitPrice = 300, UnitsInStock = 10 },
        new Product { ProductId = 5, ProductName = "Desk", Category = "Furniture", UnitPrice = 150, UnitsInStock = 5 },
        new Product { ProductId = 6, ProductName = "Chair", Category = "Furniture", UnitPrice = 85, UnitsInStock = 0 },
        new Product { ProductId = 7, ProductName = "Notebook", Category = "Stationery", UnitPrice = 3, UnitsInStock = 100 },
        new Product { ProductId = 8, ProductName = "Pen", Category = "Stationery", UnitPrice = 1.5m, UnitsInStock = 200 },
        new Product { ProductId = 9, ProductName = "Tablet", Category = "Electronics", UnitPrice = 450, UnitsInStock = 8 },
        new Product { ProductId = 10, ProductName = "Printer", Category = "Electronics", UnitPrice = 250, UnitsInStock = 0 }
    };

        // Customers with Orders
        public static List<Customer> Customers = new List<Customer>
    {
        new Customer
        {
            CustomerId = 1,
            CustomerName = "TechCorp",
            City = "Seattle",
            Orders = new List<Order>
            {
                new Order { OrderId = 101, OrderDate = new DateTime(1998, 5, 12), Total = 450.50m },
                new Order { OrderId = 102, OrderDate = new DateTime(1998, 8, 25), Total = 320.00m },
                new Order { OrderId = 103, OrderDate = new DateTime(1999, 2, 10), Total = 150.75m }
            }
        },
        new Customer
        {
            CustomerId = 2,
            CustomerName = "Global Solutions",
            City = "New York",
            Orders = new List<Order>
            {
                new Order { OrderId = 201, OrderDate = new DateTime(1997, 11, 5), Total = 780.00m },
                new Order { OrderId = 202, OrderDate = new DateTime(1999, 6, 15), Total = 290.50m }
            }
        },
        new Customer
        {
            CustomerId = 3,
            CustomerName = "Innovate Inc",
            City = "Seattle",
            Orders = new List<Order>
            {
                new Order { OrderId = 301, OrderDate = new DateTime(1998, 12, 20), Total = 520.00m },
                new Order { OrderId = 302, OrderDate = new DateTime(2000, 3, 8), Total = 410.25m }
            }
        }
    };
    }
}
