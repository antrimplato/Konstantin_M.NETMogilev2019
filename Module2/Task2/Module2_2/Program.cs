using System;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age (full number of years): ");
            int age = CheckInputOfAge(Console.ReadLine());

            if (age % 2 != 0 && age > 13 && age < 18)
                Console.WriteLine("High school congratulations!");
            else if (age == 18)
                Console.WriteLine("Сongratulations on adulthood!");
            else if (age % 2 == 0 && age > 18 && age <69)
                Console.WriteLine("Сongratulations, you are adult!");
            else if (age == 69)
                Console.WriteLine("Hehe!");
            else if (age > 69)
                Console.WriteLine("Сongratulations, you are old!");
            else Console.WriteLine("No messages for you.");

            Console.ReadKey();
        }

        //validation of the entered age
        static int CheckInputOfAge(string x)         {
            if (int.TryParse(x, out int n))             {                 if (n > 0)                     return n;                 else                     Console.Write("Enter the correct number (positive integer): ");                     string b = Console.ReadLine();                     return CheckInputOfAge(b);             }             else                 Console.Write("Enter the correct number: ");                 string a = Console.ReadLine();                 return CheckInputOfAge(a);         }
    }
}