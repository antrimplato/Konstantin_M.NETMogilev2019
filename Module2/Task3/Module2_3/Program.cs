using System;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            float a = CheckInput(Console.ReadLine());
            Console.Write("Enter number B: ");
            float b = CheckInput(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Your numbers: ");
            Console.Write("A = " + a + " ");
            Console.WriteLine("B = " + b + " ");

            a += b;             b = a - b;             a -= b;

            Console.WriteLine("Swapped numbers: ");
            Console.Write("A = " + a + " ");
            Console.WriteLine("B = " + b + " ");
        }

        //validation of the entered number
        static float CheckInput(string x)  
        {
            bool b = float.TryParse(x, out float f);
            if (!b)
            {
                Console.Write("Enter the correct number (use ',' as a delimiter): ");
                string n = Console.ReadLine();
                return CheckInput(n);
            }
            else
            return f;
        }

    }
}
