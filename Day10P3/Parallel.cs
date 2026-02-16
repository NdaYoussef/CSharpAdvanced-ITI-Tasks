using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10P3
{
    public class Parallel
    {
        public static void MakeCoffee()
        {
            Console.WriteLine("Making Coffee Parallel");
            Thread.Sleep(3000);
           
        }

        public static void ToastingBread()
        {
            Console.WriteLine("Toasting Bread Parallel");
            Thread.Sleep(2000);
            
        }

        public static void FryingEggs()
        {
            Console.WriteLine("Frying Eggs Parallel");
            Thread.Sleep(4000);
          
        }
    }
}
