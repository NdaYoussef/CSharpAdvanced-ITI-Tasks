using System.Security.Cryptography.X509Certificates;

namespace Day2P2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Dictionary
            //Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>();
            //studentGrades["nda"] = new List<int> { 10, 20, 30 };
            //studentGrades["ali"] = new List<int> { 98, 70, 50 };
            //studentGrades["ahmed"] = new List<int> { 26, 88, 50 };
            //studentGrades["mai"] = new List<int> { 92, 100, 40 };



            //foreach (var student in studentGrades)
            //{
            //    Console.WriteLine($"Student name: {student.Key} has average degree: {student.Value.Average()}");

            //}
            //Console.WriteLine("=====================================================");


            //foreach (var student in studentGrades)
            //{
            //    Console.WriteLine($"Student name: {student.Key} and high degree is: {student.Value.Max()}");
            //}
            #endregion


            #region Queue

            //Queue<string> ToDoList = new Queue<string>();

            //ToDoList.Enqueue("task1");
            //ToDoList.Enqueue("task2");
            //ToDoList.Enqueue("task3");
            //ToDoList.Enqueue("task4");
            //ToDoList.Enqueue("task5");

            //ToDoList.Dequeue();
            //foreach (var task in ToDoList)
            //{
            //    Console.WriteLine($"Task No: {task}, all tasks count: {ToDoList.Count}");
            //} 
            #endregion


            #region Dictionary #2
            PhoneNumber number = new PhoneNumber();
            number.AddPhoneNo("nda", 1245533);
            int no = number.GetPhoneNo("nda");
            Console.WriteLine($"phone no is: {no}");
            #endregion


            #region Stack
            Browser browser = new Browser();
            browser.AddPage("page1");
            browser.AddPage("page2");
            browser.AddPage("page3");
            browser.AddPage("page4");
          

            browser.RollbackPage();

            #endregion







        }
    }
}
