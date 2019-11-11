using System;

namespace Module2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a shape for calculate:");
            Console.WriteLine("1 - for Triangle, 2 - for Square, 3 - for Circle");
            double selection = CheckInput(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("You have chosen a Triangle");
                    Selector();
                    break;
                case 2:
                    Console.WriteLine("You have chosen a Square");
                    Selector();
                    break;
                case 3:
                    Console.WriteLine("You have chosen a Circle");
                    Selector();
                    break;
                default:
                    Console.WriteLine("You have chosen wrong value");
                    Console.ReadLine();
                    break;
            }
        }

        static void Selector()
        {
            double lenght;
            Console.WriteLine("What will be calculated:");
            Console.WriteLine("1 - Perimeter, 2 for the Area");
            double selection = CheckInput(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Perimete chosen");
                    Console.WriteLine("Enter radius or lenght of side");
                    lenght = CheckInput(Console.ReadLine());
                    Perimeter(lenght);
                    break;
                case 2:
                    Console.WriteLine("Area chosen");
                    Console.WriteLine("Enter radius or lenght of side");
                    lenght = CheckInput(Console.ReadLine());
                    Area(lenght);
                    break;
                default:
                    Console.WriteLine("You have chosen wrong value");
                    Console.ReadLine();
                    break;
            }
        }

        static void Perimeter(double lenght)
        {
            const double PI = Math.PI;

            double trianglePer = 3 * lenght;
            Console.WriteLine("Triangle perimeter is " + trianglePer);

            double squarePer = 4 * lenght;
            Console.WriteLine("Square perimeter is " + squarePer);

            double circlePer = 2 * lenght * PI;
            Console.WriteLine("Circle perimeter is " + circlePer);
            Console.ReadLine();
        }

        static void Area(double lenght)
        {
            const double PI = Math.PI;

            double halfPer = 3 * lenght / 2;
            double triangleArea = Math.Sqrt(halfPer * (halfPer - lenght) * (halfPer - lenght) * (halfPer - lenght));
            Console.WriteLine("Triangle perimeter is " + triangleArea);

            double squareArea = lenght * lenght;
            Console.WriteLine("Square perimeter is " + squareArea);

            double circleArea = lenght * lenght * PI;
            Console.WriteLine("Circle perimeter is " + circleArea);
            Console.ReadLine();
        }

        //validation of the entered value
        static float CheckInput(string x)
        {
            if (float.TryParse(x, out float n))
            {
                if (n > 0)
                    return n;
                else
                    Console.Write("Incorrect value! Enter a positive value: ");
                string b = Console.ReadLine();
                return CheckInput(b);
            }
            else
                Console.Write("Incorrect value! Enter a positive value (use ',' as a delimiter): ");
            string a = Console.ReadLine();
            return CheckInput(a);
        }
    }
}