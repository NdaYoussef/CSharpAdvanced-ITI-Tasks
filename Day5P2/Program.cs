namespace Day5P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region #1 Extension

            string email = "ndayou@gmail.com";

            string email2 = "ndayougmail.com";

            var validEmail = Test.checkEmail(email);
            var validEmail2 = Test.checkEmail(email2);
            var validEmail3 = Test.checkEmailRegEx(email);
            var validEmail4 = Test.checkEmailRegEx(email2);



            Console.WriteLine($"Is Email valid, {validEmail}");
            Console.WriteLine($"Is Email valid, {validEmail2}");
            Console.WriteLine($"Is Email valid, {validEmail3}");
            Console.WriteLine($"Is Email valid, {validEmail2}");
            #endregion
            Console.WriteLine("===============================================================");
            #region #2 Extension

            IEnumerable<int> noList = new List<int> { 50, 30, 87, 254, 124, 789, 1000 };

            var averageList = Test2.GetAboveAverage(noList);
            foreach (int i in averageList)
            {
                Console.WriteLine($"all numbers have big average: {i}");
            }
            #endregion
            Console.WriteLine("===============================================================");

            #region #Extensions
            var date = DateTime.UtcNow;
            Console.WriteLine($"current test date is: {Test3.ToFriendlyDate(date)}"); 
            #endregion
        }
    }
}
