using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
        int a, b, c;
        public void FindLargest()
        {
            Console.Write("Enter the first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + " is the greatest of all");
            }
            else if (b > c && b > a)
            { 
                Console.WriteLine(b + " is the greatet of all");
            }
            else
            {
                Console.WriteLine(c + " is the greatest of all ");
            }
        }
    }
}
