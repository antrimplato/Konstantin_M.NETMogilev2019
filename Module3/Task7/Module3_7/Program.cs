using System;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int arrayLength = CheckInput(Console.ReadLine());

            ImRandomArray(arrayLength);
            Console.ReadKey();
        }

        static void ImRandomArray(int arrayLength)
        {
            int[] array = new int[arrayLength];
            Random rand = new Random();

            for (int counter = 0; counter < array.Length; counter++)
                array[counter] = rand.Next(-9, 9);

            Console.WriteLine("Your random array:");
            Console.WriteLine(string.Join(" ", array));

            GreaterArrNums(array);
        }

        static void GreaterArrNums(int[] array)
        {
            Console.WriteLine("Compared numbers is: ");
            for (int counter = 0; counter < array.Length - 1; counter++)
            {
                if (array[counter + 1] > array[counter])
                    Console.Write(array[counter + 1] + " ");
            }
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && (parsedInp > 0))
            {
                return parsedInp;
            }

            else
            {
                Console.Write("Enter the correct number: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}