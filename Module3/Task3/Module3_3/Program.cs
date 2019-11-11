using System;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, do you like the Fibonacci Sequence? Choose number of elements: ");
            int usersNum = CheckInput(Console.ReadLine());

            int counter = 3;
            ulong fiboNum1 = 1;
            ulong fiboNum2 = 1;

            Console.Write("0 1");

            if (usersNum > 2)
            {
                Console.Write(" 1 ");
                for (fiboNum1 = 1; counter < usersNum; counter++)
                {
                    fiboNum1 += fiboNum2;
                    Console.Write(fiboNum1);
                    Console.Write(" ");
                    fiboNum1 += fiboNum2;
                    fiboNum2 = fiboNum1 - fiboNum2;
                    fiboNum1 -= fiboNum2;
                }
            }
            Console.ReadKey();
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && (parsedInp > 1))
            {
                return parsedInp;
            }

            else
            {
                Console.Write("Enter the correct number of elements: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}