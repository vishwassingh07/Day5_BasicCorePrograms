using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientAndRemainder
    {
        public void ComputingQuotientRemainder()
        {
            Console.Write("Enter the Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
