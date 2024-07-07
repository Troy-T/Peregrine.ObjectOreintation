using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overiding
{
    class AreaOfShapes : AreaOfSquare
    {
        public double Rectangle(double a, double b)
        {
            //return area of a rectangle
            return a*b;
        }
        //Overides the sqaure method in AreaOfSquare
        public override double Sqaure(double a, double b)
        {
            //return area of a sqaure using a different implementation
            Console.WriteLine("Area of shapes called sqaure a * b");
            return a * b;
        }
    }
}
