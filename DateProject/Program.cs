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

        static int getYear(int [] yearArray)
        {
            int year = (yearArray[3] * 1000) + (yearArray[2] * 100) + (yearArray[1] * 10) + yearArray[0];
            return year;
        }

        static int getMonth (int [] monthArray)
        {
            int month = (monthArray[7] * 10) + monthArray[6];
            return month;
        }

        static int getDay (int [] dayArray)
        {
            int day = (dayArray[5] * 10) + dayArray[4];
            return day;
        }

        static void Main()
        {
            string input1 = "07032017";
            string input2 = "06022017";
            int[] inputarray1 = inputToArray(input1);
            int[] inputarray2 = inputToArray(input2);

            DateTime firstDate = new System.DateTime(getYear(inputarray1), getMonth(inputarray1), getDay(inputarray1), 0, 0, 0);
            DateTime secondDate = new System.DateTime(getYear(inputarray2), getMonth(inputarray2), getDay(inputarray2), 0, 0, 0);
            Console.WriteLine(firstDate);
            Console.WriteLine(secondDate);
            TimeSpan diffResult = firstDate - secondDate;
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
