using System;

namespace Module4_3
{
    class Program
    {
        static void Main()
        {
            //+10 
            Console.Write("Enter 1st variable: ");
            int var1 = CheckInput(Console.ReadLine());
            Console.Write("Enter 2nd variable: ");
            int varRef2 = CheckInput(Console.ReadLine());

            var1 = PlusTen(var1, ref varRef2, out int varOut3);
            Console.WriteLine("1st variable after passing by value: " + var1);
            Console.WriteLine("2st variable after passing by reference: " + varRef2);
            Console.WriteLine("3st variable after passing by out: " + varOut3);
            Console.WriteLine();

            //Perimeter and Area
            Console.Write("Enter radius of circle: ");
            int radius = CheckInput(Console.ReadLine());
            Console.WriteLine();
            double perimeter = 0;

            AreaAndPerimeter(radius, ref perimeter, out double area);
            Console.WriteLine("Circle perimeter: " + perimeter);
            Console.WriteLine("Circle area: " + area);
            Console.WriteLine();

            //Array 
            double[] arr = { var1, varRef2, radius, perimeter, area };
            double sum = 0;
            Console.WriteLine("Array: ");
            Console.WriteLine(string.Join("  ", arr));
            Console.WriteLine();

            sum = MaxMinSumArr(arr, out double max, out double min, ref sum);
            Console.WriteLine("Max element: " + max);
            Console.WriteLine("Min element: " + min);
            Console.WriteLine("Sum of elements: " + sum);

            Console.ReadKey();
        }

        static int PlusTen(int varValue1, ref int varRef2, out int varOut3)
        {
            Console.Write("Enter 3d variable: ");
            varOut3 = CheckInput(Console.ReadLine());
            Console.WriteLine();

            varValue1 += 10;
            varRef2 += 10;
            varOut3 += 10;

            return varValue1;
        }

        static void AreaAndPerimeter(int radius, ref double perimeter, out double area)
        {
            const double PI = Math.PI;

            perimeter = 2 * radius * PI;
            area = radius * radius * PI;
        }

        static double MaxMinSumArr(double[] arr, out double max, out double min, ref double sum)
        {
            max = arr[0];
            for (int counter = 0; arr.Length > counter; counter++)
            {
                if (arr[counter] > max)
                {
                    max = arr[counter];
                }
            }

            min = arr[0];
            for (int counter = 0; arr.Length > counter; counter++)
            {
                if (arr[counter] < min)
                {
                    min = arr[counter];
                }
            }

            sum = 0;
            for (int counter = 0; arr.Length > counter; counter++)
            {
                sum += arr[counter];
            }

            return sum;
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp))
            {
                return parsedInp;
            }

            else
            {
                Console.Write("Enter the correct integer: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}