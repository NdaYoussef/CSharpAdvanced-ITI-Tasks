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


        }
    }
}
