using System;
namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basice Core Programs....");
            bool end = true;
            Console.WriteLine("1. Flip Coin Percentage Problem\n2. Checking Leap Year Program\n3." +
                " Table Of Power Of Two\n4. Harmonic Series\n5. Prime Factors\n6. " +
                "Computing Quotient And Remainder\n7. Swapping Numbers\n8. End The Program");
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
                        LeapYear checking = new LeapYear();
                        checking.CheckingLeapYear();
                        break;
                    case 3:
                        PowerOfTwo table = new PowerOfTwo();
                        table.PowerOf2();
                        break;
                    case 4:
                        HarmonicNumberValue series = new HarmonicNumberValue();
                        series.HarmonicNumber();
                        break;
                    case 5:
                        PrimeFactors factors = new PrimeFactors();
                        factors.Prime();
                        break;
                    case 6:
                        QuotientAndRemainder computing = new QuotientAndRemainder();
                        computing.ComputingQuotientRemainder();
                        break;
                    case 7:
                        SwappingNumbers swapping = new SwappingNumbers();
                        swapping.Swap();
                        break;
                    case 8:
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