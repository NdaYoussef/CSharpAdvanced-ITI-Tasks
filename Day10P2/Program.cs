using System.Runtime.CompilerServices;

namespace Day10P2
{
    internal class Program
    {

        public static async Task<long> CalcFactorial(int n)
        {

            //if (n == 0 || n == 1)
            //    return 1;
            
            long fact = 1; 
            for(int i = 2; i <= n; i++)
            {
                fact *= i;
            }
       
          //  long resul = fact;
            //Console.WriteLine($"result = {resul}");
            return fact;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Task<long> ts = Task.Run(() => CalcFactorial(5));

            TaskAwaiter<long> awaiterTs1 = ts.GetAwaiter();

            awaiterTs1.OnCompleted(() =>
            {
                Console.WriteLine($"factorial of task 1: {ts.Result}");
            }
            );
            Console.WriteLine("============================================");
            Task<long> ts2 = Task.Run(() => CalcFactorial(10));
            TaskAwaiter<long> awaiterTs2 = ts2.GetAwaiter();

            awaiterTs2.OnCompleted(() =>
            {
                Console.WriteLine($"factorial of task 2: {ts2.Result}");
            }
            );
            Console.WriteLine("============================================");

            Task<long> ts3 = Task.Run(() => CalcFactorial(15));
            TaskAwaiter<long> awaiterTs3 = ts3.GetAwaiter();
            awaiterTs3.OnCompleted(() =>
            {
                Console.WriteLine($"factorial of task 3: {ts3.Result}");
            }
            );


            Task<long> ts4 = Task.Run(() => CalcFactorial(12));
            TaskAwaiter<long> awaiterTs4 = ts4.GetAwaiter();
            awaiterTs4.OnCompleted(() =>
            {
                Console.WriteLine($"factorial of task 4: { ts4.Result}");
            }
            );
            Console.WriteLine("============================================");


            Task.WaitAll(ts,ts2,ts3,ts4);
            Console.WriteLine("end of program");


        }
    }
}
