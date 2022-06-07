using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PrimeFactors
    {
        public void Prime()
        {
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors for {0} is ", number);

            for(int i =2; i< number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
