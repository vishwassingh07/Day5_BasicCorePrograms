using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwappingNumbers
    {
        public void Swap()
        {
            Console.Write("Enter a first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After Swapping First Number : " + num1);
            Console.WriteLine("After Swapping Second Number : " + num2);
        }
    }
}
