using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class CheckingEvenOdd
    {
        public void EvenOdd()
        {
            Console.Write("Enter a number to check for even or odd : ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if(number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number ");
            }
            else
            {
                Console.WriteLine(number + " is an odd number ");
            }
        }
    }
}
