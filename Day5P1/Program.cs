namespace Day5P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            var anon = new { id = 1 };
            var test = Test.keyValuePairs();

          //  Test.keyValuePairs(anon);
            List<Dictionary<string, object>> keyValuePairs = new List<Dictionary<string, object>>();

            Console.WriteLine(keyValuePairs);
            Console.WriteLine(test);
        }
    }
}
