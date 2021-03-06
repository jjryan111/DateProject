﻿using System;

namespace DateProject
{
    class Program
    {   
    static DateTime getInput(string which)
        {
            string inputString = "";
            bool goodDate = false;
            DateTime checkedDate = new System.DateTime(1900,01,01,0,0,0);
            while (!goodDate)
            {
                Console.Write("Enter the {0} date: ", which);
                inputString = Console.ReadLine();
                goodDate = DateTime.TryParse(inputString, out checkedDate);
                if (!goodDate)
                { 
                Console.WriteLine("That's not a date!");
                }
            }
            checkedDate = Convert.ToDateTime(inputString);
            return checkedDate;
        }

        static void Main()
        {
            string whichDate = "first";
            // I found the next couple of lines as a result of a Google search. 
            // I wrote code that basically does this in prior commits but this works better.
            DateTime firstDate = getInput(whichDate);
            whichDate = "second";
            DateTime secondDate = getInput(whichDate);
            TimeSpan diffResult = firstDate - secondDate;
            int diffDate = Convert.ToInt32(Math.Abs(diffResult.TotalDays));
            int yearsDiff = diffDate / 365;
            int monthsDiff = (diffDate - (yearsDiff*365))/30;
            int daysDiff = (diffDate - (yearsDiff * 365) - (monthsDiff * 30));
            // This is always going to be really inaccurate, as timespan takes things 
            // like a non-averaged month length and leap years into account.
            // I would need a hint on the logic to make this work in any real way.
            Console.WriteLine("The difference is {0} years, {1} months, and {2} days. Press enter to continue.",yearsDiff,monthsDiff,daysDiff);
            Console.Read();
        }
    }
}
