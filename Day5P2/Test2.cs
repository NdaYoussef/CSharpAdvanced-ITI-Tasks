using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5P2
{
    public static class Test2
    {
        public static IEnumerable<int> GetAboveAverage(this IEnumerable<int> numbers)
        {
            //IEnumerable<int> result = numbers;

            double avg = numbers.Average();

           IEnumerable<int> aboveAgeList = numbers.Where(t => t > avg);
            //foreach (int i in aboveAgeList)
            //{
            //    Console.WriteLine($"Average of all numbers: {i}");
            //}
            return aboveAgeList;
        }
    }
}
