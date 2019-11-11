using System;

namespace Module4_6
{
    class Program
    {
        static int arrayLength = 10;
        static int[] array = new int[arrayLength];

        static void Main()
        {
            Array();
            Console.WriteLine("Random array: ");
            Console.WriteLine(string.Join("  ", array));
            Console.WriteLine();

            Add5ToArr();
            Console.WriteLine("Random array after method: ");
            Console.WriteLine(string.Join("  ", array));

            Console.ReadKey();
        }

        static void Add5ToArr()
        {
            for (int counter = 0; counter < array.Length; counter++)
                array[counter] = array[counter] + 5;
        }

        static int[] Array()
        {
            Random rand = new Random();

            for (int counter = 0; counter < array.Length; counter++)
                array[counter] = rand.Next(-9, 9);

            return array;
        }
    }
}