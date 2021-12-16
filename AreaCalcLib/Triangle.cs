using System;

namespace AreaCalcLib
{
    public class Triangle
    {
        double ac, bc, ab;


        public Triangle(double x, double y, double z)
        {
            ac = x;
            bc = y;
            ab = z;
        }

        public double AreaCalc()
        {
            double p = (ac + ab + bc) / 2;

            double square = Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));

            return square;
        }

        public bool IsRightAngled()
        {
            if ((ac * ac + ab * ab == bc * bc) 
                || (ac * ac + bc * bc == ab * ab) 
                || (bc * bc + ab * ab == ac * ac))
                return true;
            return false;
        }
    }
}
