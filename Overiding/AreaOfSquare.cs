using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overiding
{
    class AreaOfSquare
    {
        public virtual double Sqaure(double a, double b)
        {
            Console.WriteLine("Calculate the area of a sqaure, power a/\b");
            return Math.Pow(a, 2);
        }
    }
}
