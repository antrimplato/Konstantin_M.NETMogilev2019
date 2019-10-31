using System;

namespace Module4_4
{
    class Program
    {
        public static void Main()
        {
            //+10 
            Console.Write("Enter 1st variable: ");
            int enteredVar1 = CheckInput(Console.ReadLine());
            Console.Write("Enter 2nd variable: ");
            int enteredVar2 = CheckInput(Console.ReadLine());
            Console.Write("Enter 2nd variable: ");
            int enteredVar3 = CheckInput(Console.ReadLine());
            Console.WriteLine();

            (double var1, int var2, int var3) = GetTen((enteredVar1, enteredVar2, enteredVar3));
            Console.WriteLine("1st variable after GetTen method: " + var1);
            Console.WriteLine("2st variable after GetTen method: " + var2);
            Console.WriteLine("3st variable after GetTen method: " + var3);
            Console.WriteLine();

            //Perimeter and Area
            Console.Write("Enter radius of circle: ");
            int rad = CheckInput(Console.ReadLine());
            Console.WriteLine();

            (int radius, double perimeter, double area) = AreaAndPerimeter((rad, 0, 0));
            Console.WriteLine("Circle perimeter: " + perimeter);
            Console.WriteLine("Circle area: " + area);
            Console.WriteLine();

            //Array 
            double[] array = { var1, var2, var3, radius, perimeter, area };
            Console.WriteLine("Array: ");
            Console.WriteLine(string.Join("  ", array));
            Console.WriteLine();

            var (max, min, sum) = MaxMinSumArr(array);
            Console.WriteLine("Max element: " + max);
            Console.WriteLine("Min element: " + min);
            Console.WriteLine("Sum of elements: " + sum);

            Console.ReadKey();
        }


        public static (int, int, int) GetTen((int, int, int) plusTenVariables)
        {
            var result = (var1: plusTenVariables.Item1 + 10, var2: plusTenVariables.Item2 + 10, var3: plusTenVariables.Item3 + 10);
            return result;
        }


        static (int, double, double) AreaAndPerimeter((int radius, double perimeter, double area) radiusPerimeterArea)
        {
            const double PI = Math.PI;

            var result = (radius: radiusPerimeterArea.radius, perimeter: 2 * radiusPerimeterArea.radius * PI, area: radiusPerimeterArea.radius * radiusPerimeterArea.radius * PI);
            return result;
        }


        static (double max, double min, double sum) MaxMinSumArr(double[] arr)
        {
            var result = (max: arr[0], min: arr[0], sum: 0.0);

            for (int counter = 0; arr.Length > counter; counter++)
            {
                if (arr[counter] > result.max)
                {
                    result.max = arr[counter];
                }
            }

            for (int counter = 0; arr.Length > counter; counter++)
            {
                if (arr[counter] < result.min)
                {
                    result.min = arr[counter];
                }
            }

            for (int counter = 0; arr.Length > counter; counter++)
            {
                result.sum += arr[counter];
            }

            return result;
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