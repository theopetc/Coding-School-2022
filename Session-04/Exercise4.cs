using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise4
    {
        public Exercise4()
        {

        }

        public string Multiplication()
        {
            string result = String.Empty;
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    result += $"{array1[i] * array2[j]} ";
                }
            }

            return result;
        }
    }
}
