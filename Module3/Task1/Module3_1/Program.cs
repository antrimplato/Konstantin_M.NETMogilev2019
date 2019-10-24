using System;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning! Multiplication of numbers will be executed without multiplication!");
            Console.WriteLine("Prepare your funny integers!");

            Console.Write("Enter first integer here: ");
            int firstnum = CheckInput(Console.ReadLine());

            Console.Write("And enter second integer: ");
            int secondnum = CheckInput(Console.ReadLine());

            Console.WriteLine(Multiplication(firstnum, secondnum) + "   voila");
            Console.WriteLine();
            Console.WriteLine("Multiplication check: " + (firstnum * secondnum));
            Console.ReadKey();
        }

        public static int Multiplication(int firstnum, int secondnum)
        {
            int valueOfMultiplication = 0;
            int counter = 0;

            if ((firstnum > 0 && secondnum <0) || (firstnum < 0 && secondnum > 0))
            {
                firstnum = Math.Abs(firstnum);
                secondnum = Math.Abs(secondnum);

                for (counter = firstnum; counter > 0; counter--)
                {
                    valueOfMultiplication += secondnum;
                }
                valueOfMultiplication = valueOfMultiplication / -1;
                return valueOfMultiplication;
            }

            else
            {
                firstnum = Math.Abs(firstnum);
                secondnum = Math.Abs(secondnum);

                for (counter = firstnum; counter > 0; counter--)
                {
                    valueOfMultiplication += secondnum;
                }
                return valueOfMultiplication;
            }
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp))
            {
                return parsedInp;
            }
             
            else
            {
                Console.Write("It's not funny, enter the correct integer: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}