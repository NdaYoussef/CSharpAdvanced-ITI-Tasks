namespace Day10P1
{
    internal class Program
    {
       static int sum = 0;
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        public static void Sum()
        {
            Console.WriteLine($"outer Thread : {Thread.CurrentThread.ManagedThreadId}, Name: {Thread.CurrentThread.Name}, Status: {Thread.CurrentThread.ThreadState}, IsAlive: {Thread.CurrentThread.IsAlive}, IsBackground: {Thread.CurrentThread.IsBackground} ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                    sum+= numbers[i];   
            }
            Console.WriteLine($"even sum: {sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ThreadStart myThread = Sum;
            // thread.Start();

            Thread thread = new Thread(myThread);
            thread.Start();
            Console.WriteLine($"Inner main Thread : {Thread.CurrentThread.ManagedThreadId}, Name: {Thread.CurrentThread.Name}, Status: {Thread.CurrentThread.ThreadState}, IsAlive: {Thread.CurrentThread.IsAlive}, IsBackground: {Thread.CurrentThread.IsBackground} ");

            for (int i = 0; i < numbers.Length; i++)
            {
                   
                    if(i%2 != 0)
                    sum += numbers[i];

            }
            Console.WriteLine($"Odd Sum = {sum}");
            Console.WriteLine("End of Program");

        }
    }
}
