using System;
using AreaCalcLib;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(3, 4, 5);
            Circle cir = new Circle(6);

            Console.WriteLine(tr.AreaCalc());
            Console.WriteLine(tr.IsRightAngled());

            Console.WriteLine();
            Console.WriteLine(cir.AreaCalc());
        }
    }
}
