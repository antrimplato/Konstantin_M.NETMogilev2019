using System;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, do you like a natural numbers? Choose one of them: ");
            int usersNum = CheckInput(Console.ReadLine());

            int counter = 0;

            for (int numCounter = 1; counter <= usersNum; numCounter++)
            {
                if (numCounter % 2 == 0)
                {
                    Console.Write(numCounter);
                    if (counter == usersNum - 1)
                        break;
                    Console.Write(", ");
                    counter++;
                }
            }
            Console.ReadKey();
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && (parsedInp > 0))
            {
                    return parsedInp;
            }

            else
            {
                Console.Write("Enter the correct natural number: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}