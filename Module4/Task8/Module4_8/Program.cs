using System;

namespace Module4_8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine ("Function: 2 * x^3 - 1");

            EnterPoints(out double aPoint, out double bPoint);
            double accuracy = 0.0001;
            double solution = 0;
            double midPoint = (bPoint + aPoint)/2;

            if (Math.Sign(Function(aPoint)) == Math.Sign(Function(bPoint)))
            {
                Console.WriteLine("Solution does not exist for the selected pointss. Choose a smaller segment.");
                EnterPoints(out aPoint, out bPoint);
            }

            Console.WriteLine("Solution: " + BisectionRecursion(solution, aPoint, bPoint, midPoint, accuracy));
            Console.ReadKey();
        }

        static double BisectionRecursion (double solution, double aPoint, double bPoint, double midPoint, double accuracy)
        {
            if (Math.Abs(Function(aPoint)) < accuracy)
                return aPoint;

            if (Math.Abs(Function(bPoint)) < accuracy)
                return bPoint;
                
            if (bPoint - aPoint > accuracy)
            {
                midPoint = aPoint + (bPoint - aPoint) / 2;

                if (Math.Sign(Function(aPoint)) == Math.Sign(Function(midPoint)))
                    aPoint = midPoint;
                else
                    bPoint = midPoint;

                return BisectionRecursion(solution, aPoint, bPoint, midPoint, accuracy);
            }

            return midPoint;
        }

        static double Function (double var)
        {
            return Math.Pow(var, 3) * 2 - 1;
        }

        static void EnterPoints(out double a, out double b)
        {
            Console.Write("Enter A point: ");
            double aPoint = CheckInput(Console.ReadLine());
            Console.Write("Enter B point: ");
            double bPoint = CheckInput(Console.ReadLine());

            a = aPoint;
            b = bPoint;
        }

        static double CheckInput(string inp)
        {
            if (double.TryParse(inp, out double parsedInp))
                return parsedInp;
                
            Console.Write("Enter the correct point: ");
            string correctInp = Console.ReadLine();
            return CheckInput(correctInp);
        }
    }
}