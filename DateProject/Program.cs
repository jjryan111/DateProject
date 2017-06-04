using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {
        static int[] inputToArray(string input)
        {
            int date = Convert.ToInt32(input);
            int[] d1array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int counter = 0;
            while (counter < 8)
            {
                d1array[counter] = date % 10;
                date = date / 10;
                counter++;
            }
            return d1array;
        }
        static int getYear(int[] yearArray)
        {
            int year = (yearArray[3] * 1000) + (yearArray[2] * 100) + (yearArray[1] * 10) + yearArray[0];
            return year;
        }
        static int getMonth(int[] monthArray)
        {
            int month = (monthArray[7] * 10) + monthArray[6];
            return month;
        }
        static int getDay(int[] dayArray)
        {
            int day = (dayArray[5] * 10) + dayArray[4];
            return day;
        }
        static int [] dateCheck()
        {
            bool badInput = true;
            string checkString = "";
            int[] checkArray = { 0, 0, 0, 0, 0, 0, 0, 0 };
            while (badInput)
            {
                badInput = false;
                Console.Write("Enter in a date as MMDDYYYY: ");
                checkString = Console.ReadLine();
                try
                {
                    Convert.ToInt32(checkString);
                }
                catch (Exception)
                {
                    Console.WriteLine("Hey! That's not a date! Try again.");
                    badInput = true;
                }
                if(!badInput)
                {
                    int inputNum = Convert.ToInt32(checkString);
                    if((inputNum > 12319999) || (inputNum <1010001))
                    {
                        Console.WriteLine("Hey! That's not a date! Try again.");
                        badInput = true;
                    }
                    else
                    {
                        checkArray = inputToArray(checkString);
                        if ((getDay(checkArray) > 31) || (getDay(checkArray) < 1))
                        {
                            badInput = true;
                            Console.WriteLine("How many days in a month?");
                        }
                        if (getDay(checkArray) > 30 && (getMonth(checkArray)== 4 || getMonth(checkArray) == 6 || getMonth(checkArray) == 9 || getMonth(checkArray) == 11))
                        {
                            badInput = true;
                            Console.WriteLine("Thirty days has September, April, June and November!");
                        }
                        if (getMonth (checkArray) == 2 && (getDay(checkArray) > 28))
                        {
                            badInput = true;
                            Console.WriteLine("February only has 28 days.");
                        }
                    }
                   
                }

            }
            return checkArray;
        }
        static void Main()
        {
            int [] inputarray1 = dateCheck();
            int [] inputarray2 = dateCheck();
            DateTime firstDate = new System.DateTime(getYear(inputarray1), getMonth(inputarray1), getDay(inputarray1), 0, 0, 0);
            DateTime secondDate = new System.DateTime(getYear(inputarray2), getMonth(inputarray2), getDay(inputarray2), 0, 0, 0);
            TimeSpan diffResult = firstDate - secondDate;
            int diffDate = Convert.ToInt32(Math.Abs(diffResult.TotalDays));
            int yearsDiff = diffDate / 365;
            int monthsDiff = (diffDate - (yearsDiff*365))/30;
            int daysDiff = (diffDate - (yearsDiff * 365) - (monthsDiff * 30));
            Console.Write("The difference is {0} years, {1} months, and {2} days.",yearsDiff,monthsDiff,daysDiff);
            Console.Read();
        }
    }
}
