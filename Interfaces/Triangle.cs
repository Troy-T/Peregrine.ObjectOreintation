using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : IShape
    {
        public double height { get; set; }
        public double @base { get; set; }

        public double Area()
        {
            return height * @base / 2;
        }

        //Assumes Right Angled Triangle
        public double perimeter()
        {
            double pythagoras = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(@base, 2));
            return pythagoras + height + @base;
        }
    }
}
