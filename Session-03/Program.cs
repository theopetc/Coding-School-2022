using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor();
            Console.WriteLine("Before SetName " + p.GetName());
            p.SetName("Giannis");
            Console.WriteLine("After SetName " + p.GetName());


            Console.ReadLine();
        }
    }
}
