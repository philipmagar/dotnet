using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] calendarView = new int[12][]; // 12 months

            // Initialize each month with a varying number of days
            calendarView[0] = new int[31]; // January (31 days)
            calendarView[1] = new int[28]; // February (28 days, assuming non-leap year)
            calendarView[2] = new int[31]; // March (31 days)
            calendarView[3] = new int[30]; //arpril
            calendarView[4] = new int[31]; // May
            calendarView[5] = new int[30]; //june
            calendarView[6] = new int[31]; // july
            calendarView[7] = new int[30]; //august
            calendarView[8] = new int[31]; // setember
            calendarView[9] = new int[30]; //october
            calendarView[10] = new int[31]; // november
            calendarView[11] = new int[30]; //december


            //calendar view with events or appointments
            calendarView[0][0] = 1; // Event on January 1st
            calendarView[1][14] = 2; // Event on February 14th
            calendarView[2][20] = 3; // Event on March 20th


            // Accessing and iterating over the calendar view
            for (int month = 0; month < 12; month++)
            {
                for (int day = 0; day < calendarView[month].Length; day++)
                {
                    if (calendarView[month][day] > 0) // event or appointment present
                    {
                        Console.WriteLine($"Event on {month + 1}/{day + 1}");
                    }
                }
            }
        }
    }
}