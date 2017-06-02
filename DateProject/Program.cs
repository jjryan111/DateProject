using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "12132016";
            string input2 = "05102017";
           int date1 = Convert.ToInt32(input1);
            int date2 = Convert.ToInt32(input2);
            int[] d1array = new int[]{0, 0, 0, 0, 0, 0, 0, 0};
            int[] d2array = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int counter = 0;
            while (counter < 8)
            {
                d1array[counter] = date1 % 10;
                date1 = date1 / 10;
                counter++;
            }
            counter = 0;
            while (counter < 8)
            {
                d2array[counter] = date2 % 10;
                date2 = date2 / 10;
                counter++;
            }
            int year1 = d1array[0] + (d1array[1] * 10) + (d1array[2] * 100) + (d1array[3] * 1000); Console.WriteLine(year1);
            int year2 = d2array[0] + (d2array[1] * 10) + (d2array[2] * 100) + (d2array[3] * 1000); Console.WriteLine(year2);
            int day1 = d1array[5] + (d1array[4] * 10); Console.WriteLine(day1);
            int day2 = d2array[5] + (d2array[4] * 10); Console.WriteLine(day2);
            int month1 = d1array[6] + (d1array[7] * 10); Console.WriteLine(month1);
            int month2 = d2array[6] + (d2array[7] * 10); Console.WriteLine(month2);
            int monthdays1 = 0;
            int monthdays2 = 0;
            switch (month1)
            {
                case 1:
                    monthdays1 = 0;
                    break;
                case 2:
                    monthdays1 = 31;
                    break;
                case 3:
                    monthdays1 = 31 + 28;
                    break;
                case 4:
                    monthdays1 = 31 + 28 + 31;
                    break;
                case 5:
                    monthdays1 = 31 + 28 + 31 + 30;
                    break;
                case 6:
                    monthdays1 = 31 + 28 + 31 + 30 + 31;
                    break;
                case 7:
                    monthdays1 = 31 + 28 + 31 + 30 + 31 + 30;
                    break;
                case 8:
                    monthdays1 = 31 + 28 + 31 + 30 + 31 + 30 + 31;
                    break;
                case 9:
                    monthdays1 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                    break;
                case 10:
                    monthdays1 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                    break;
                case 11:
                    monthdays1 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                    break;
                case 12:
                    monthdays1 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                    break;
//                default:
//                    Console.WriteLine("Error in input");
//                    break;
            }
            switch (month2)
            {
                case 1:
                    monthdays2 = 0;
                    break;
                case 2:
                    monthdays2 = 31;
                    break;
                case 3:
                    monthdays2 = 31 + 28;
                    break;
                case 4:
                    monthdays2 = 31 + 28 + 31;
                    break;
                case 5:
                    monthdays2 = 31 + 28 + 31 + 30;
                    break;
                case 6:
                    monthdays2 = 31 + 28 + 31 + 30 + 31;
                    break;
                case 7:
                    monthdays2 = 31 + 28 + 31 + 30 + 31 + 30;
                    break;
                case 8:
                    monthdays2 = 31 + 28 + 31 + 30 + 31 + 30 + 31;
                    break;
                case 9:
                    monthdays2 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
                    break;
                case 10:
                    monthdays2 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
                    break;
                case 11:
                    monthdays2 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
                    break;
                case 12:
                    monthdays2 = 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
                    break;
//                default:
//                    Console.WriteLine("Error in input");
//                    break;
            }
            Console.WriteLine(monthdays1);
            Console.WriteLine(monthdays2);
            int totalDate1 = year1 + monthdays1 + day1;
            int totalDate2 = year2 + monthdays2 + day2;
            int diffDate = totalDate1 - totalDate2;
            Console.WriteLine(diffDate);
            Console.Read();
        }
    }
}
