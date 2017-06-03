using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {
        
        static void Main()
        {
            DateTime dtToday = new System.DateTime(2012, 6, 2, 0, 0, 0);
            DateTime dtMonthBefore = new System.DateTime(2012, 5, 2, 0, 0, 0);
            TimeSpan diffResult = dtToday.Subtract(dtMonthBefore);
            int diffDate = Convert.ToInt32(diffResult.TotalDays);
            int yearsDiff = diffDate / 365;
            int monthsDiff = (diffDate - (yearsDiff*365))/30;
            int daysDiff = (diffDate - (yearsDiff * 365) - (monthsDiff * 30));
            Console.WriteLine(diffDate);
            Console.WriteLine(yearsDiff);
            Console.WriteLine(monthsDiff);
            Console.WriteLine(daysDiff);
            Console.Read();
        }
    }
}
