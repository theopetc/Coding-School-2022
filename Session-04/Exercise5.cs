using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise5
    {
        public Exercise5()
        {

        }

        public string Sort(int[] array)
        {
            int length = array.Length;
            string result = String.Empty;
            int temp;

            for (int i = 0; i < length; i++)
            {
                temp = array[i];
                for (int j = i; j < length; j++)
                {
                    if (array[j] < temp)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }

                result += $"{temp} ";
                
            }

            return result;
        }
    }
}
