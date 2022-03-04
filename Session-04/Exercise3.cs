using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise3
    {
        public Exercise3()
        {
            
        }

        public string Prime(int n)
        {
            string result = String.Empty;
            if (!IsPositive(n)){} //Different approach from Exercise 2
            
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    result += $"{i} ";
                }
            }
            return result;
        }

        private bool IsPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPositive(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Your input is invalid!");
                Console.Write("Press any key to continue...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return true;
        }
    }
}
