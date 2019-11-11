using System;

namespace Module4_2
{
    class Program
    {

        static void Main()
        {
            SumAll SumMethod = new SumAll();

            Console.Write("Enter the length of array_1: ");
            int arrayLength1 = CheckInput(Console.ReadLine());
            Console.Write("Enter the length of array_2: ");
            int arrayLength2 = CheckInput(Console.ReadLine());
            int[] arr1 = new int[arrayLength1];
            int[] arr2 = new int[arrayLength2];

            Console.Clear();
            Console.Write("Array_1: ");
            RandomArray(arr1);
            Console.Write("Array_2: ");
            RandomArray(arr2);
            Console.WriteLine();

            SumMethod.Sum(4, 2);
            SumMethod.Sum(4, 2, 71);
            SumMethod.Sum(0.2, 1.9, 2.3);
            SumMethod.Sum("croco", "dile");
            SumMethod.Sum(arr1, arr2);

            Console.ReadKey();
        }

        static int[] RandomArray(int[] arr)
        {
            Random rand = new Random();

            for (int counter = 0; arr.Length > counter; counter++)
                arr[counter] = rand.Next(-9, 9);

            Console.WriteLine(string.Join(" ", arr));
            return arr;
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && (parsedInp > 0))
            {
                return parsedInp;
            }

            else
            {
                Console.Write("Enter the correct integer: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }


    class SumAll
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum of 2 integers: " + a + b);
        }

        public void Sum(int a, int b, int c)
        {
            Console.WriteLine("Sum of 3 integers: " + a + b + c);
        }

        public void Sum(double a, double b, double c)
        {
            Console.WriteLine("Sum of 3 fractional numbers: " + a + b + c);
        }

        public void Sum(string a, string b)
        {
            Console.WriteLine("Sum of 2 strings: " + a + b);
        }

        public void Sum(int[] arr1, int[] arr2)
        {
            Console.Write("Sum of arrays: ");

            int sumArrLenght;
            int countOfSums;

            if (arr1.Length > arr2.Length)
            {
                sumArrLenght = arr1.Length;
                countOfSums = arr2.Length;

            }
            else
            {
                sumArrLenght = arr2.Length;
                countOfSums = arr1.Length;
            }

            int[] sumArr = new int[sumArrLenght];

            for (int counter = 0; countOfSums > counter; counter++)
            {
                sumArr[counter] = arr1[counter] + arr2[counter];
            }

            for (int counter = countOfSums; sumArrLenght > counter; counter++)
            {
                sumArr[counter] = (arr1.Length > arr2.Length) ? arr1[counter] : arr2[counter];
            }

            Console.WriteLine(string.Join("  ", sumArr));
        }
    }
}