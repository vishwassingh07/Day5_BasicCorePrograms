using System;
namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basice Core Programs....");
            bool end = true;
            Console.WriteLine("1. Flip Coin Percentage Problem\n2. End The Program");
            while (end)
            {
                Console.WriteLine("Choose an option to execute...");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.FlipPercent();
                        break;
                    case 2:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option...");
                        break;
                }
            }
        }
    }
}