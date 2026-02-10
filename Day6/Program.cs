namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-1
            IEnumerable<Department> DeptList = SampleData.Departments.Select(d => new Department { DeptName = d.DeptName, Address = d.Address });

            //var DeptList = SampleData.Departments.Select(d => new { DeptName = d.DeptName, Address = d.Address });

            foreach (Department dept in DeptList)
            {
                Console.WriteLine($"Department Name: {dept.DeptName}, DepartmentAddress: {dept.Address}");
            }
            Console.WriteLine("2 ================================================================");


            //-2
            IEnumerable<Product> products = SampleData.Products.Where(p => p.UnitsInStock == 0);

            foreach (Product product in products)
                Console.WriteLine($"All products that have no units in stock: {product.ProductName}");
            Console.WriteLine("3 ================================================================");

            //-3

            IEnumerable<Product> productsList = SampleData.Products.Where(p => p.UnitsInStock == 0 && p.UnitPrice > 100);

            foreach (Product product in productsList)
                Console.WriteLine($"All products that have no units in stock and unit price greater than 100: {product.ProductName}");
            Console.WriteLine("4 ================================================================");

            //-4
            var employees = SampleData.Employees.Count(e => e.Salary > 20000);
            Console.WriteLine($"Count of Employess: {employees}");

            Console.WriteLine("5 ================================================================");

            //5- 
            IEnumerable<Course> courses = SampleData.Courses.Where(e => e.Hours > 55).Take(3);

            foreach (Course course in courses)
            {
                Console.WriteLine($"First 3 courses: {course.CourseName}");
            }

            Console.WriteLine("6 ================================================================");

            //6-
            //IEnumerable<Subject> subjectList = from Subject in SampleData.Subjects
            //                                   orderby Subject.SubjectName ascending
            //                                   thenby 

            //var subjects = SampleData.Subjects.Join(SampleData.Courses, sub => sub.SubjectId, crs => crs.SubjectId, (sub, crs) => new { CourseName = $"{crs.CourseName}"}).OrderBy(n=>n.)

            IEnumerable<Course> listCourses = SampleData.Courses.OrderBy(c=>c.SubjectId).ThenByDescending(c=>c.Hours).Select(c => new Course { CourseName = c.CourseName, Hours = c.Hours });



            Console.WriteLine("7================================================================");

            //7-
            var productsListByName = SampleData.Products.OrderBy(n=>n.ProductName);

            foreach (var product  in productsListByName)
            {
                Console.WriteLine($"Product: {product}");
            }

            Console.WriteLine("8 ================================================================");

            //-8
            var EmployeeDept = SampleData.Employees.Join(SampleData.Departments, emp => emp.DeptId, dept => dept.DeptId, (emp, dept) =>
            new { EmployeeName = $"{emp.EmpName}", DepartmentName = $"{dept.DeptName}" });

            foreach (var emp in EmployeeDept)
            {
                Console.WriteLine($"Employee Name: {emp.EmployeeName}, Employee Department: {emp.DepartmentName}");
            }

            Console.WriteLine("9 ================================================================");

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

            Console.WriteLine("10 ================================================================");

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

            Console.WriteLine("11 ================================================================");

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

            Console.WriteLine("12 ================================================================");

            //-12


            var productListMini = SampleData.Products.GroupBy(p => p.Category).Select(p => new
            {
                Category = p.Key,
                MinimumPrice = p.Min(p => p.UnitsInStock),
                MinimProduct = p.MinBy(p => p.UnitsInStock)
            });

            foreach (var product in productListMini)
            {
                Console.WriteLine($"Product Category: {product.Category}, MinimumPrice: {product.MinimumPrice}, MinimumName: {product.MinimProduct.ProductName}");
            }

            Console.WriteLine("13 ================================================================");

            //-13
            var customers = SampleData.Customers.Select(p => new
            {
                CustomerName = p.CustomerName,
                TotalCountOfOrders = p.Orders.Count,
            });

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer Name: {customer.CustomerName}, Total No Of orders: {customer.TotalCountOfOrders}");
            }


            Console.WriteLine("14 ================================================================");
             //-14
             var uniqueCategory = SampleData.Products.Select(p=>p.Category).Distinct();
            foreach (var product in uniqueCategory)
            {
                Console.WriteLine($"Unique Category Name: {product}");
            }

            Console.WriteLine("15 ================================================================");
            //-15
            var ProductCategory = SampleData.Products.GroupBy(p => p.Category).Select(p => new
            {
                Category = p.Key,
             //   ProductName = p.Select(p=>p.ProductName),
                ProductMaximumPrice = p.MaxBy(p => p.UnitPrice),

            });

            foreach (var product in ProductCategory)
            {
                Console.WriteLine($"Product Category: {product.Category},ProductName: {product.ProductMaximumPrice.ProductName}, Maximum Price: {product.ProductMaximumPrice.UnitPrice} ");
               
            }

            Console.WriteLine("16 ================================================================");
            //-16

           var firstProduct = SampleData.Products.FirstOrDefault(p => p.UnitsInStock == 0);


            Console.WriteLine($"First product has no items in stock: {firstProduct.ProductName}");


            Console.WriteLine("17 ================================================================");
            //-17
            IEnumerable<string> productNames = SampleData.Products.Select(p=> new string(p.ProductName)).Distinct();
            foreach (var product in productNames)
            {
                Console.WriteLine($"Product Name: {product}");
            }

        }
    }
}
