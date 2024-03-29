﻿using System;

namespace module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Income = 500;

            Console.Write("Enter the number of companies: ");
            int n = CheckInputNOC(Console.ReadLine());

            Console.Write("Enter tax percentage: ");
            float m = CheckInputTP(Console.ReadLine());
            Console.WriteLine();

            var TaxSum = n * Income * m / 100;

            Console.WriteLine("Total tax: " + TaxSum);
            Console.ReadKey();
        }

        //validation of the entered value (number of companies)
        static int CheckInputNOC(string x)
        {
            if (int.TryParse(x, out int n))
            {
                if (n > 0)
                    return n;
                else
                {
                    Console.Write("Incorrect value! Enter a integer greater than zero: ");
                    string a = Console.ReadLine();
                    return CheckInputNOC(a);
                }
            }
            else
            {
                Console.Write("Incorrect value! Enter a integer greater than zero: ");
                string a = Console.ReadLine();
                return CheckInputNOC(a);
            }
        }

        //validation of the entered value (tax percentage)
        static float CheckInputTP(string x)
        {
            if (float.TryParse(x, out float n))
            {
                if (n > 0)
                    return n;
                else
                {
                    Console.Write("Incorrect value! Enter a positive value (use ',' as a delimiter): ");
                    string a = Console.ReadLine();
                    return CheckInputTP(a);
                }
            }
            else
            {
                Console.Write("Incorrect value! Enter a positive value (use ',' as a delimiter): ");
                string a = Console.ReadLine();
                return CheckInputTP(a);
            }
        }
    }
}