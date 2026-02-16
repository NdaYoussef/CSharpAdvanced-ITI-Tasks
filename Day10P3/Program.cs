using System.Diagnostics;

namespace Day10P3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            // ================= Sequential =================
            Stopwatch sw = Stopwatch.StartNew();

            Seqential.MakCoffee();
            Seqential.ToastingBread();
            Seqential.FryingEggs();

            sw.Stop();
            Console.WriteLine("=================================");
            Console.WriteLine($"Sequential Time: {sw.ElapsedMilliseconds} ms");

            // ================= Parallel =================
            Stopwatch sw2 = Stopwatch.StartNew();

            Task coffeeTask = Task.Run(() => Parallel.MakeCoffee());
            Task breadTask = Task.Run(() => Parallel.ToastingBread());
            Task eggTask = Task.Run(() => Parallel.FryingEggs());

             Task.WhenAll(coffeeTask, breadTask, eggTask);

            sw2.Stop();
            Console.WriteLine("=================================");
            Console.WriteLine($"Parallel Time: {sw2.ElapsedMilliseconds} ms");
        }
    }
    }

