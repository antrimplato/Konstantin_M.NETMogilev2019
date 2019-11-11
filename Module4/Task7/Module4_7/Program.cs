using System;

namespace Module4_7
{
    class Program
    {
        static int arrayLength = 10;
        static int[] array = new int[arrayLength];

        enum WayToSort
        {
            ascending,
            descending
        }

        static void Main()
        {
            RandomArray();
            Console.WriteLine("Random array: ");
            Console.WriteLine(string.Join("  ", array));
            Console.WriteLine();

            SortArr(WayToSort.ascending);
            Console.WriteLine("Array after sorting ascending: ");
            Console.WriteLine(string.Join("  ", array));
            SortArr(WayToSort.descending);
            Console.WriteLine("Array after sorting descending: ");
            Console.WriteLine(string.Join("  ", array));

            Console.ReadKey();
        }

        static void SortArr(WayToSort way)
        {
            switch (way)
            {
                case WayToSort.ascending:
                    for (int counter = 0; counter < arrayLength - 1; counter++)
                    {
                        for (int counter2 = counter + 1; counter2 < arrayLength; counter2++)
                        {
                            if (array[counter] > array[counter2])
                            {
                                array[counter] += array[counter2];
                                array[counter2] = array[counter] - array[counter2];
                                array[counter] -= array[counter2];
                            }
                        }
                    }
                    break;

                case WayToSort.descending:
                    for (int counter = 0; counter < arrayLength - 1; counter++)
                    {
                        for (int counter2 = counter + 1; counter2 < arrayLength; counter2++)
                        {
                            if (array[counter] < array[counter2])
                            {
                                array[counter] += array[counter2];
                                array[counter2] = array[counter] - array[counter2];
                                array[counter] -= array[counter2];
                            }
                        }
                    }
                    break;
            }
        }

        static int[] RandomArray()
        {
            Random rand = new Random();

            for (int counter = 0; counter < array.Length; counter++)
                array[counter] = rand.Next(-9, 9);

            return array;
        }
    }
}