﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Circle : IShape
    {
        public double radius { get; set; }

        public double Area()
        {
            return Math.PI * radius;
        }

        public double perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
