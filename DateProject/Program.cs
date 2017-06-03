using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {
        static int[] inputToArray (string input)
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
        static int getMonth(int monthValue)
        {
            switch (monthValue)
            {
                case 1:
                    monthValue = 0;
                    break;
                case 2:
                    monthValue = 31;
                    break;
                case 3:
                    monthValue = 31 + 28;
                    break;
                case 4:
                    monthValue = 31 + 28 + 31;
                    break;
                case 5:
                    monthValue = 31 + 28 + 31 + 30;
                    break;
                case 6:
                    monthValue = 31 + 28 + 31 + 30 + 31;
                    break;
                case 7:
                    monthValue = 31 + 28 + 31 + 30 + 31 + 30;
                    break;
                case 8:
                    monthValue = 31 + 28 + 31 + 30 + 31 + 30 + 31;
                    break;
                case 9:
                    monthValue = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                    break;
                case 10:
                    monthValue = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                    break;
                case 11:
                    monthValue = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                    break;
                case 12:
                    monthValue = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                    break;
                    //                default:
                    //                    Console.WriteLine("Error in input");
                    //                    break;
            }
            return monthValue;
        }
        static void Main()
        {
            string input1 = "01012017";
            string input2 = "02112011";
            int [] d1array = inputToArray(input1);
            int [] d2array = inputToArray(input2);
            int year1 = d1array[0] + (d1array[1] * 10) + (d1array[2] * 100) + (d1array[3] * 1000); // Console.WriteLine(year1);
            int year2 = d2array[0] + (d2array[1] * 10) + (d2array[2] * 100) + (d2array[3] * 1000); // Console.WriteLine(year2);
            int day1 = d1array[4] + (d1array[5] * 10); // Console.WriteLine(day1);
            int day2 = d2array[4] + (d2array[5] * 10); // Console.WriteLine(day2);
            int month1 = d1array[6] + (d1array[7] * 10); // Console.WriteLine(month1);
            int month2 = d2array[6] + (d2array[7] * 10); // Console.WriteLine(month2);
            int monthdays1 = getMonth(month1);
            int monthdays2 = getMonth(month2);
           // Console.WriteLine(monthdays1);
           //  Console.WriteLine(monthdays2);
            int totalDate1 = (year1 * 365) + monthdays1 + day1;
            int totalDate2 = (year2 * 365) + monthdays2 + day2;
            int diffDate = Math.Abs(totalDate1 - totalDate2);
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
