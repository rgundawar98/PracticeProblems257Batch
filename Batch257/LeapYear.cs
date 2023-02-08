using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch257
{
    public class LeapYear
    {
        public static void DisplayYear()
        {
            Console.WriteLine("Enter the year to check it is leap or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            { 
                Console.WriteLine(year + " is leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("is not leap year");
            }
            else
            {
                Console.WriteLine("It is not leap year");
            }
        }
    }
}
