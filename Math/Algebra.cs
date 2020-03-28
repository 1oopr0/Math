using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Algebra
    {
        public static (double RootPlus, double RootMinus) GetRootsOfQuadraticEquation(double a, double b, double c)
        {
            var pm = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

            return ((-b + pm) / (2 * a), (-b - pm) / (2 * a));
        }
    }
}
