using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
       public void FlipPercent()
        {
            int headCount = 0, tailCount = 0;
            Console.WriteLine("How many flips do you want ? ");
            int flipNumber = Convert.ToInt32(Console.ReadLine());

            while(flipNumber <= 0)
            {
                Console.WriteLine("Invalid input , please enter a valid number greater than 0");
                flipNumber = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < flipNumber; i++)
            {
                Random flip = new Random();
                int option = flip.Next(0, 2);

                if (option > headCount)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
            }
            Console.WriteLine("Number of heads : {0} ", headCount);
            Console.WriteLine("Number of tails : {0} ", tailCount);
            float headPercentage = (float)headCount * 100 / flipNumber;
            float tailPercentage = (float)tailCount * 100 / flipNumber;
            Console.WriteLine("Percentage of Head : {0} ", headPercentage);
            Console.WriteLine("Percentage of Tail : {0} ", tailPercentage);
        }
    }
}
