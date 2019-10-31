using System;
using System.Globalization;


namespace Module4_5
{
    class Program
    {
        enum MathOperation
        {
            Addition = 1,
            Subtract,
            Multiply,
            Divide
        }

        static void Main(string[] args)
        {
            //math operations
            double var1 = 1.3;
            double var2 = 2.6;
            Console.WriteLine("1st variable: " + var1);
            Console.WriteLine("2nd variable: " + var2);
            Console.WriteLine();

            MathOp(var1, var2, MathOperation.Addition);
            MathOp(var1, var2, MathOperation.Subtract);
            MathOp(var1, var2, MathOperation.Multiply);
            MathOp(var1, var2, MathOperation.Divide);
            Console.WriteLine();

            //days in month
            Console.Write("Enter the year: ");
            int year = CheckInput(Console.ReadLine());
            Console.Write("Enter the month: ");
            int month = CheckInput(Console.ReadLine());
            (int, int) tuple = (year, month);

            Console.WriteLine("In {0} {1} - {2} days", CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month), year, DaysInMonthMethod(tuple));
            Console.ReadKey();
        }

        static void MathOp(double var1, double var2, MathOperation operation)
        {
            double result = 0;

            switch (operation)
            {
                case MathOperation.Addition:
                    result = var1 + var2;
                    break;
                case MathOperation.Subtract:
                    result = var1 - var2;
                    break;
                case MathOperation.Multiply:
                    result = var1 * var2;
                    break;
                case MathOperation.Divide:
                    result = var1 / var2;
                    break;
            }

            Console.WriteLine("Result of {0} = {1}", operation, result);
        }

        static int DaysInMonthMethod((int year, int month) tuple)
        {
            int days = DateTime.DaysInMonth(tuple.year, tuple.month);
            return days;
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && (parsedInp > 0) && (parsedInp < 9999))
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