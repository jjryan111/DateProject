using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {   
    static DateTime getInput()
        {
            string inputString = "";
            bool badDate = true;
            DateTime checkedDate = new System.DateTime(1900,01,01,0,0,0);
            while (badDate)
            {
                badDate = false;
                Console.Write("Enter date: ");
                inputString = Console.ReadLine();
                try
                {
                    checkedDate = Convert.ToDateTime(inputString);
                }
                catch (Exception)
                {
                    badDate = true;
                    Console.WriteLine("That's not a date!");
                }
            }
            checkedDate = Convert.ToDateTime(inputString);
            return checkedDate;
        }

        static void Main()
        {
            // I found the next 3 lines as a result of a Google search. 
            // I wrote code that basically does this in prior commits but this works better.
            DateTime firstDate = getInput();
            DateTime secondDate = getInput();
            TimeSpan diffResult = firstDate - secondDate;
            int diffDate = Convert.ToInt32(Math.Abs(diffResult.TotalDays));
            int yearsDiff = diffDate / 365;
            int monthsDiff = (diffDate - (yearsDiff*365))/30;
            int daysDiff = (diffDate - (yearsDiff * 365) - (monthsDiff * 30));
            // This is always going to be really inaccurate, as timespan takes things 
            // like a non-averaged month length and leap years into account.
            // I would need a hint on the logic to make this work in any real way.
            Console.WriteLine("The difference is {0} years, {1} months, and {2} days.",yearsDiff,monthsDiff,daysDiff);
            Console.WriteLine("That's it. Press Enter to continue.");
            Console.Read();
        }
    }
}
