using System;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputArray;
            Console.WriteLine("Enter the numbers of your array for reverse: ");
            string usersInp = CheckInput(Console.ReadLine());

            inputArray = usersInp.ToCharArray();
            Array.Reverse(inputArray);

            Console.WriteLine(inputArray);
            Console.ReadKey();
        }

        static string CheckInput(string inp)
        {
            if (decimal.TryParse(inp, out decimal parsedInp) && parsedInp > 0)
            {
                return parsedInp.ToString();
            }

            else
            {
                Console.Write("Enter the correct numbers: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}