using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class CheckingVowelConsonant
    {
        char value;
        public void alphabetcheck()
        {
            Console.Write("Enter an alphabet to check : ");
            value = Convert.ToChar(Console.ReadLine().ToLower());

            if (value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u')
            {
                Console.WriteLine(value + " is a vowel");
            }
            else
            {
                Console.WriteLine(value + " is a consonant");
            }
        }
    }
}
