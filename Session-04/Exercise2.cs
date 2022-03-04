using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise2
    {
        public Exercise2()
        {
        
        }

        public int GetProduct(int n)
        {
            int result = 1;
            if (IsPositive(n))
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }                
            }
            return result;
        }

        public int GetSum(int n)
        {
            int result = 0;
            if (IsPositive(n))
            {
                for (int i = 0; i <= n; i++)
                {
                    result += i;
                }
            }
            return result;
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
