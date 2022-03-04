using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Theodoros";
            Exercise1 exercise1 = new Exercise1();
            string result = exercise1.ReverseString(name);

            Console.WriteLine("My name is {0} and reversed it is {1}", name, result);
           
            //*****************************************************************

            Console.Write("Please enter a positive integer: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            
            Exercise2 exercise2 = new Exercise2();
            int result2;
            
            result2 = exercise2.GetProduct(n);
            Console.WriteLine("{0} factorial is {1}", n, result2);
            
            result2 = exercise2.GetSum(n);
            Console.WriteLine("Sum of numbers 1..{0} is {1}", n, result2);
            
            input = String.Empty;

            //*****************************************************************

            Console.Write("Please enter a positive integer: ");
            input = Console.ReadLine();
            n = Convert.ToInt32(input);

            Exercise3 exercise3 = new Exercise3();
            string result3 = exercise3.Prime(n);

            Console.WriteLine(result3);

            input = String.Empty;

            //*****************************************************************

            Exercise4 exercise4 = new Exercise4();
            string result4 = exercise4.Multiplication();

            Console.WriteLine("Answer to exercise 4 is: " + result4);
            
            //*****************************************************************

            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Exercise5 exercise5 = new Exercise5();
            string result5 = exercise5.Sort(array);

            Console.WriteLine("Answer to exercise 5 is: " + result5);
            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
