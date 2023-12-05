using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleUsingQuadro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coefficients of the quadratic equation (a, b, c):");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            var result = QuadraticEquation.CalculateRoots(a, b, c);

            if (result.HasRoots)
            {
                Console.WriteLine($"Roots of the equation with coefficients a = {a}, b = {b}, c = {c} are different: x1 = {result.Root1}, x2 = {result.Root2}");
            }
            else if (result.HasOneRoot)
            {
                Console.WriteLine($"The root of the equation with coefficients a = {a}, b = {b}, c = {c} is one: x1 = x2 = {result.Root1}");
            }
            else
            {
                Console.WriteLine($"There are no roots of the equation with coefficients a = {a}, b = {b}, c = {c}.");
            }
        }
    }
}
