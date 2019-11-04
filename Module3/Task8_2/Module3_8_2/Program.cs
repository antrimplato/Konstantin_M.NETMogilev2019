using System;

namespace Module3_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int arraySize = CheckInput(Console.ReadLine());

            GetSpiral(arraySize);
            Console.ReadKey();
        }

        public static void GetSpiral(int arraySize)
        {
            int[,] array = new int[arraySize, arraySize];
            int row = 0;
            int column = 0;
            int dx = 1;
            int dy = 0;
            int turns = (arraySize - 1) * 2;
            int calls = arraySize;
            int tempCalls = arraySize;
            int temp = 0;

            for (int counter = 0; counter < array.Length; counter++)
            {
                array[row, column] = counter + 1;

                if (--calls == 0)
                {
                    turns--;
                    if (turns % 2 == 1)
                    {
                        tempCalls -= 1;
                        calls = tempCalls;
                    }

                    calls = tempCalls;

                    temp = dx;
                    dx = -dy;
                    dy = temp;
                }
                row += dy;
                column += dx;
            }

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static int CheckInput(string inp)
        {
            if (int.TryParse(inp, out int parsedInp) && parsedInp > 0)
                return parsedInp;

            Console.Write("Enter the correct size: ");
            string correctInp = Console.ReadLine();
            return CheckInput(correctInp);

        }
    }
}