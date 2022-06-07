using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumberValue
    {
        public void HarmonicNumber()
        {
            float harmonic = 0;

            Console.Write("Enter the value of N for Nth harmonic : ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N == 0)
            {
                Console.WriteLine("Please enter number more than 0 ");
                N = Convert.ToInt32(Console.ReadLine());
            }
                for (float i = 1; i <= N; i++)
                {
                    harmonic += 1 / i;                  
                }
            Console.WriteLine("The Nth Harmonic Value is {0} ", harmonic);
        }
    }
}
