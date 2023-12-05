using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleUsingQuadro
{
    internal class QuadraticEquation
    {
        public static (bool HasRoots, bool HasOneRoot, double Root1, double Root2) CalculateRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double x1 = (-b + sqrtDiscriminant) / (2 * a);
                double x2 = (-b - sqrtDiscriminant) / (2 * a);
                return (true, false, x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return (false, true, x, x);
            }
            else
            {
                return (false, false, 0, 0);
            }
        }
    }
}
