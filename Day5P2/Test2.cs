using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5P2
{
    public static class Test2
    {
        public static List<int> GetAboveAverage(this IEnumerable<int> numbers)
        {
            List<int> result = [];

            double avg = numbers.Average();

           //List<int> aboveAgeList = numbers.Where(t => t > avg);
            foreach (int i in numbers)
            {
                if(i>avg)
                    result.Add(i);
               // Console.WriteLine($"Average of all numbers: {i}");
            }
            return result;
        }
    }
}
