﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            string name = "Theodoros Petsagkas";

            Console.WriteLine("Hello " + name);
            Console.WriteLine();

            //2.
            int a = 2;
            int b = 5;
            int sum = a + b;
            decimal division = a / (decimal)b;

            Console.WriteLine("Sum of " + a + " and " + b + " is " + sum);
            Console.WriteLine("Division of " + a + " with " + b + " is " + division);
            Console.WriteLine();

            //3.
            int result1 = -1 + 5 * 6;
            int result2 = 38 + 5 % 7;
            decimal result3 = 14 + ((-3 * 6) / (decimal)7);
            decimal result4 = 2 + ((13 / (decimal)6) * 6) + (decimal)Math.Sqrt(7);
            double result5 = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
            Console.WriteLine("First result is " + result1);
            Console.WriteLine("Second result is " + result2);
            Console.WriteLine("Third result is " + result3);
            Console.WriteLine("Fourth result is " + result4);
            Console.WriteLine("Fifth result is " + result5);
            Console.WriteLine();

            //4.
            int age = 22;
            string gender = "female";

            Console.WriteLine("You are " + gender + " and look younger than " + age);

            Console.ReadLine();
        }
    }
}
