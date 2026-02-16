using Microsoft.EntityFrameworkCore;

namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            AppDbContext db = new AppDbContext();

            Console.WriteLine("1===============================================");
            //-1
            var courses = db.Courses.ToList();
            foreach (var crs in courses)
            {
                Console.WriteLine($"Crs Name: {crs.Name}");
                foreach (var item in crs.Students)
                {
                    Console.WriteLine($"Students list: {item.Name}");
                }
            }

            Console.WriteLine("2===============================================");
            //-2
            var students = db.Students.Where(c => c.CourseId == 3).Take(5);

            foreach(var student in students)
            {
                student.GPA += 0.5;
                Console.WriteLine($"Student Name: {student.Name}, Student GPA: {student.GPA} ");
            }

            
            db.SaveChanges();


            Console.WriteLine("3===============================================");
            //-3
            var studentsList = db.Students.Take(5).Skip(2);
            foreach (var student in studentsList)
            {
                Console.WriteLine($"Std Name: {student.Name}");
            }

            Console.WriteLine("4===============================================");
            //-4

            var listStds = db.Students.FromSqlRaw($"exec sp_ALlStudents");
            listStds = listStds.OrderBy(n=>n.Name);
            foreach(var student in listStds)
            {
                Console.WriteLine($"Std Name: {student.Name}, Student GPA: {student.GPA}");
            }

            var listStds2 = db.Students.FromSqlInterpolated($"exec sp_ALlStudents");
            listStds = listStds.OrderBy(n => n.Name);
            foreach (var student in listStds)
            {
                Console.WriteLine($"Std Name: {student.Name}, Student Crs Name: {student.Course.Name}");
            }

            //var StdsWithCrs = db.Students.FromSqlRaw($"select * from dbo.vw_StdWithCrs").ToList();
            //foreach (var student in listStds)
            //{
            //    Console.WriteLine($"Std Name: {student.Name}, Student Course: {student.Course.Name}, Student GPA: {student.GPA}");
            //}


            var data = db.Set<StdViewModel>();
            foreach (var student in data)
            {
                Console.WriteLine($"Std Name: {student.StudentName}, Course Name: {student.CrsName}, Student GPA: {student.StdGPA}");
            }

          

        }
    }
}
