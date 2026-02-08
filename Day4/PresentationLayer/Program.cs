using BusinessLayer.Models;
using BusinessLayer;
namespace PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AuthorManager manager = new AuthorManager();

            bool exit = false;

            while (!exit)
            {

                Console.WriteLine("==== HR Author Management ====");
                Console.WriteLine("1- Show Authors");
                Console.WriteLine("2- Add Author");
                Console.WriteLine("3- Delete Author");
                Console.WriteLine("4- Exit");

                Console.Write("Choice: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        var authors = manager.GetAllAuthors();

                        foreach (var a in authors)
                        {
                            Console.WriteLine($"{a.Id} - {a.FirstName} {a.LastName}");
                        }

                        break;

                    case "2":
                        Author newAuthor = new Author();

                        Console.Write("Id: ");
                        newAuthor.Id = Console.ReadLine();

                        Console.Write("First Name: ");
                        newAuthor.FirstName = Console.ReadLine()!;

                        Console.Write("Last Name: ");
                        newAuthor.LastName = Console.ReadLine()!;

                        Console.Write("Address: ");
                        newAuthor.Address = Console.ReadLine();

                        Console.Write("City: ");
                        newAuthor.City = Console.ReadLine();

                        Console.Write("State: ");
                        newAuthor.State = Console.ReadLine();
                        Console.Write("Zip: ");
                        newAuthor.ZIP = Console.ReadLine();

                        Console.Write("Phone: ");
                        newAuthor.Phone = Console.ReadLine();

                        Console.Write("Contract: ");
                        newAuthor.ActiveContract = Convert.ToBoolean (Console.ReadLine());



                        manager.AddAuthor(newAuthor);

                        Console.WriteLine(" Author Added Successfully");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Write("Enter Id: ");
                        string id = Console.ReadLine()!;

                        manager.DeleteAuthor(id);

                        Console.WriteLine("Deleted Successfully");
                        Console.ReadKey();
                        break;

                    case "4":
                        exit = true;
                        break;
                }
            }

        }
    }
}
