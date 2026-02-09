using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5P2
{
    public static class Test3
    {
        public static string ToFriendlyDate(this DateTime date)
        {
            var TargetedDay = DateTime.Now;
            if (date == TargetedDay)
                return "Today";

            else if (date == TargetedDay.AddDays(1))
                return "Tomorrow";
            else if (date == TargetedDay.AddDays(-1))
                return "Yesterday";

            else 
                return date.ToString("dd/mm/yy");
        }
    }
}
