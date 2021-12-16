using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalcLib
{
    public class Circle
    {
        double r;
        public Circle(double radius)
        {
            r = radius;
        }

        public double AreaCalc()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
