using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_program
{
    internal class Leap_year
    {
        public void Check_leap_year()
        {
            Console.WriteLine("Enter the year in 4 digit");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine ( year+ "is a Leap Year");
            }
            else
            {
                Console.WriteLine ( year+ "is not a Leap Year");
            }
         }
    }
}
