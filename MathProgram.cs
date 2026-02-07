using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double A = 5.0;
            double B = -4.0;

            Console.WriteLine($"A: {A}, B: {B}");

            double absoluteB = Math.Abs(B);
            Console.WriteLine($"Absolute value of B: {absoluteB}");

            double ASquared = Math.Pow(A, 2);
            double BSquared = Math.Pow(absoluteB, 2);

            double h = Math.Sqrt(ASquared + BSquared);
            Console.WriteLine($"Calculated Hypotenuse: {h}");

            double ceilingA = Math.Ceiling(A);
            Console.WriteLine($"Ceiling of A: {ceilingA}");

            double sineA = Math.Sin(A);
            Console.WriteLine($"Sine of A (radians): {sineA}");

            double preciseResult = 10.5678;
            double roundedResult = Math.Round(preciseResult, 2);
            Console.WriteLine($"Rounded value of {preciseResult}: {roundedResult}");

            Console.ReadLine();
        }
    }
}
