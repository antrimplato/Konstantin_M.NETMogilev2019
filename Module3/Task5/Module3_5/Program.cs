using System;

namespace Module3_5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input your integer: ");
            string inputInteger = CheckInputInteger(Console.ReadLine());

            Console.Write("Input the number you want to exclude: ");
            string inputExclude = CheckInputExclude(Console.ReadLine());

            ExcludeNumber(inputInteger, inputExclude);
            Console.ReadKey();
        }

        static void ExcludeNumber(string inputInteger, string inputExclude)
        {
            if (inputInteger.Contains(inputExclude))
            {
                Console.Write("Your integer without an excluded number: ");
                Console.Write(inputInteger.Replace(inputExclude, ""));
            }

            else
            {
                Console.Write("Number to exclude not found! ");
                CheckInputExclude(CheckInputInteger(Console.ReadLine()));
            }
        }

        //validation of the entered integer
        static string CheckInputInteger(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && (parsedInp > -1))
            {
                return parsedInp.ToString();
            }

            else
            {
                Console.Write("Enter the correct natural number: ");
                string correctInp = Console.ReadLine();
                return CheckInputInteger(correctInp);
            }
        }

        //validation of the excluded number
        static string CheckInputExclude(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && parsedInp >= 0 && parsedInp <= 9)
            {
                return parsedInp.ToString();
            }
            else
            {
                Console.Write("Enter the correct number: ");
                string correctInp = Console.ReadLine();
                return CheckInputExclude(correctInp);
            }
        }
    }
}