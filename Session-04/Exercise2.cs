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
            //if (n <= 0)
            //{
            //    Console.WriteLine("Your input is invalid!");
            //    return 0;
            //}
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public int GetSum(int n)
        {
            //if (n <= 0)
            //{
            //    Console.WriteLine("Your input is invalid!");
            //    return;
            //}
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
