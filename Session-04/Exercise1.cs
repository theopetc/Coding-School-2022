using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise1
    {
        public Exercise1()
        {

        }
        public string ReverseString(string name)
        {
            int stringLength = name.Length;
            char[] result = new Char[stringLength];
            string finalResult = String.Empty;

            for (int i = 0; i < stringLength; i++)
            {
                result[i] += name[stringLength - i - 1];
            }

            for (int i = 0; i < stringLength; i++)
            {
                finalResult += Convert.ToString(result[i]);
            }
            
            return finalResult;
            
            //return new String(result); Alternatively
        }
    }
}
