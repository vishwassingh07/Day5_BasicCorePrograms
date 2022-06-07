using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PowerOfTwo
    {
        public void PowerOf2()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while( num < 0 || num >= 31)
            {
                Console.WriteLine("Please enter a valid number");
                num = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
