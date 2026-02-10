namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-1
            IEnumerable<Department> DeptList = SampleData.Departments.Select(d => new Department { DeptName = d.DeptName, Address = d.Address });

            //List<Department> DeptList = SampleData.Departments.Select(d => new Department { DeptName = d.DeptName, Address = d.Address });

            foreach (Department dept in DeptList)
            {
                Console.WriteLine($"Department Name: {dept.DeptName}, DepartmentAddress: {dept.Address}");
            }
            Console.WriteLine("================================================================");


            //-2
            IEnumerable<Product> products = SampleData.Products.Where(p => p.UnitsInStock == 0).ToList();

            foreach (Product product in products)
                Console.WriteLine($"All products that have no units in stock: {product.ProductName}");
            Console.WriteLine("================================================================");

            //-3

            IEnumerable<Product> productsList = SampleData.Products.Where(p => p.UnitsInStock == 0 && p.UnitPrice > 100).ToList();

            foreach (Product product in productsList)
                Console.WriteLine($"All products that have no units in stock and unit price greater than 100: {product.ProductName}");
            Console.WriteLine("================================================================");

            //-4
            var employees = SampleData.Employees.Count(e => e.Salary > 20000);
            Console.WriteLine($"Count of Employess: {employees}");

            Console.WriteLine("================================================================");

            //5- 
            List<Course> courses = SampleData.Courses.Where(e => e.Hours > 55).Take(3).ToList();

            foreach (Course course in courses)
            {
                Console.WriteLine($"First 3 courses: {course.CourseName}");
            }

            Console.WriteLine("================================================================");

            //6-
            //IEnumerable<Subject> subjectList = from Subject in SampleData.Subjects
            //                                   orderby Subject.SubjectName ascending
            //                                   thenby 

            //var subjects = SampleData.Subjects.Join(SampleData.Courses, sub => sub.SubjectId, crs => crs.SubjectId, (sub, crs) => new { CourseName = $"{crs.CourseName}"}).OrderBy(n=>n.)

            Console.WriteLine("================================================================");

            //7-
            IEnumerable<string> productsListByName = SampleData.Products.Select(n => n.ProductName).OrderBy(n=>n);

            foreach (string productName in productsListByName)
            {
                Console.WriteLine($"Product Name: {productName}");
            }

            Console.WriteLine("================================================================");

            //-8
            var EmployeeDept = SampleData.Employees.Join(SampleData.Departments, emp => emp.DeptId, dept => dept.DeptId, (emp, dept) =>
            new { EmployeeName = $"{emp.EmpName}", DepartmentName = $"{dept.DeptName}" });

            foreach (var emp in EmployeeDept)
            {
                Console.WriteLine($"Employee Name: {emp.EmployeeName}, Employee Department: {emp.DepartmentName}");
            }

            Console.WriteLine("================================================================");

            //-9
            var SubjectCrs = SampleData.Subjects.GroupJoin
                                                (SampleData.Courses,
                                                sub => sub.SubjectId, 
                                                crs=> crs.SubjectId,
                                                (sub,crs) =>
                                                new 
                                               { SubjectName = sub.SubjectName , Courses = crs.Select(c=>c.CourseName).ToList()});
            foreach (var subject in SubjectCrs)
            {
                Console.WriteLine($"Subject Name: {subject.SubjectName}");
                foreach (var crs in subject.Courses)
                {
                    Console.WriteLine($"Course: {crs}");
                }
            }

            Console.WriteLine("================================================================");

            //-10
            var coursesGrouping = SampleData.Courses.GroupBy(x => new
            {
                x.DeptId,
                x.SubjectId
            }).Select(c => new
            {
                SubjectId =c.Key.SubjectId,
                DepartmentId = c.Key.DeptId,
                Courses = c.Select(c => c.CourseName).ToList()
            });

            foreach(var course in coursesGrouping)
            {
                Console.WriteLine($"Group by SubjectId: {course.SubjectId}, Group by DepartmentId: {course.DepartmentId}");
                foreach(var crs in course.Courses )
                {
                    Console.WriteLine($"Courses: {crs}");
                }
            }

            Console.WriteLine("================================================================");

            //-11

            var productList = SampleData.Products.GroupBy(p => p.Category).Select(p => new
            {
                Category = p.Key,
                TotalUnits = p.Sum(p => p.UnitsInStock)
            });

            foreach(var product in productList)
            {
                Console.WriteLine($"Product Category: {product.Category}, TotalUnits: {product.TotalUnits}");
            }

            Console.WriteLine("================================================================");

            //-12


            var productListMini = SampleData.Products.GroupBy(p => p.Category).Select(p => new
            {
                Category = p.Key,
                MinimumPrice = p.Min(p => p.UnitsInStock)
            });

            foreach (var product in productListMini)
            {
                Console.WriteLine($"Product Category: {product.Category}, MinimumPrice: {product.MinimumPrice}");
            }

            Console.WriteLine("================================================================");

            //-13
        //    var customers = SampleData.Customers.Select(c=>c.CustomerName).Count(c=>c.Order)











        }
    }
}
