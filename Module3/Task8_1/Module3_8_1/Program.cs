using System;

namespace Module3_8_1
{
    class Program
    {
        static void Main()
        {
            EnterPoints(out double APoint, out double BPoint);

            //verification of the sequence of points
            if (APoint > BPoint)
            {
                APoint += BPoint;
                BPoint = APoint - BPoint;
                APoint -= BPoint;
            }

            BisectionMethod(APoint, BPoint);
            Console.ReadKey();
        }

        static void BisectionMethod(double APoint, double BPoint)
        {
            double solution = 0;
            double accurasy = 0.001;

            solution = (APoint + BPoint) / 2;
            while (Math.Abs(BPoint - APoint) > 2 * accurasy)
            {
                Console.WriteLine("sol = {0}  A = {1}  B = {2}", solution, APoint, BPoint);

                if ((2 * APoint * APoint + 3 * APoint - 1) * (2 * solution * solution + 3 * solution - 1) < 0)
                    BPoint = solution;

                else if ((2 * BPoint * BPoint + 3 * BPoint - 1) * (2 * solution * solution + 3 * solution - 1) < 0)
                    APoint = solution;

                else 
                {
                    Console.WriteLine("Solution does not exist for the selected segment.");
                    Console.WriteLine();
                    EnterPoints(out APoint, out BPoint);
                }

                solution = (APoint + BPoint) / 2;
            }

            Console.WriteLine();
            Console.WriteLine("Solution: " + solution);
        }

        static void EnterPoints(out double A, out double B)
        {
            Console.WriteLine("Enter A point:");
            double APoint = CheckInput(Console.ReadLine());
            Console.WriteLine("Enter B point:");
            double BPoint = CheckInput(Console.ReadLine());

            A = APoint;
            B = BPoint;
        }

        //validation of the entered value
        static double CheckInput(string inp)
        {
            if (double.TryParse(inp, out double parsedInp))
            {
                return parsedInp;
            }

            else
            {
                Console.Write("Enter the correct size: ");
                string correctInp = Console.ReadLine();
                return CheckInput(correctInp);
            }
        }
    }
}