using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadaniSolutionAssign
{
    internal class MainClass
    {
        public static string FirstReverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        } 

        public static int FirstFactorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial is: "+FirstFactorial(4));
            Console.WriteLine("Reverse of string is: "+FirstReverse("coderbyte"));
            Console.ReadLine();
        }
    }
}
