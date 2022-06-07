using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public void CheckingLeapYear()
        {
            Console.WriteLine("Enter the year you want to check for leap year ");
            int year = Convert.ToInt32(Console.ReadLine());

            while (year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter a four digit number");
                year = Convert.ToInt32(Console.ReadLine());
            }
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}
