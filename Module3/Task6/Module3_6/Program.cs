using System;

namespace Module3_6
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

            Console.WriteLine("Your random array: ");
            Console.WriteLine(string.Join(" ", array));
            ImSwitchedArray(array);
        }

        static void ImSwitchedArray(int[] array)
        {
            for (int counter = 0; counter < array.Length; counter++)
                array[counter] = -array[counter];

            Console.WriteLine("The switched array is: ");
            Console.WriteLine(string.Join(" ", array));
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