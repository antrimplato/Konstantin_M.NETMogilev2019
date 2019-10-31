using System;

namespace Module4_1
{
    class Program
    {
        static int arrayLength = 10;
        static int[] array = new int[arrayLength];
        static int maxEl;
        static int indexMax;
        static int minEl;
        static int indexMin;
        static int sumArr;
        static int differenceMaxMin;

        static void Main(string[] args)
        {
            Array();

            MaxElement();
            Console.WriteLine("Index of maximum element: {0} ({1}) ", indexMax + 1, maxEl);

            MinElement();
            Console.WriteLine("Index of minimum element: {0} ({1}) ", indexMin + 1, minEl);

            SumOfElements();
            Console.WriteLine("Summ of elements: " + sumArr);

            DifferenceMaxMin();
            Console.WriteLine("Difference between min and max: " + differenceMaxMin);

            Console.Write("Modified array: ");
            EvenAddMax_OddAddMin();

            Console.ReadKey();
        }

        static int[] Array()
        {
            Random rand = new Random();

            for (int counter = 0; counter < array.Length; counter++)
                array[counter] = rand.Next(-99, 99);

            Console.Write("Random array: ");
            Console.WriteLine(string.Join(" ", array));

            return array;
        }

        public static void MaxElement()
        {
            maxEl = array[0];

            for (int counter = 0; arrayLength > counter; counter++)
            {
                if (array[counter] > maxEl)
                {
                    maxEl = array[counter];
                    indexMax = counter;
                }
            }
        }

        public static void MinElement()
        {
            minEl = array[0];

            for (int counter = 0; arrayLength > counter; counter++)
            {
                if (array[counter] < minEl)
                {
                    minEl = array[counter];
                    indexMin = counter;
                }
            }
        }

        public static void SumOfElements()
        {
            sumArr = 0;

            for (int counter = 0; arrayLength > counter; counter++)
            {
                sumArr += array[counter];
            }
        }

        public static void DifferenceMaxMin()
        {
            differenceMaxMin = maxEl - minEl;
        }

        public static void EvenAddMax_OddAddMin()
        {
            for (int counter = 0; arrayLength > counter; counter++)
            {
                array[counter] = array[counter] % 2 == 0 ? array[counter] + maxEl : array[counter] - minEl;
                Console.Write(array[counter] + " ");
            }
        }
    }
}