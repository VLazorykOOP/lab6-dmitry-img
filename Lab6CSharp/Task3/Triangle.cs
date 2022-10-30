using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task3
{
    internal class Triangle : IFigure
    {
        
        private double _sideA;
        private double _sideB;
        private double _sideC;

        
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
      
        public double Area()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

        public double Perimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public void Print()
        {
            Console.WriteLine("Triangle:");
            Console.WriteLine("Side A: " + _sideA);
            Console.WriteLine("Side B: " + _sideB);
            Console.WriteLine("Side C: " + _sideC);
            Console.WriteLine("Area: " + Area());
            Console.WriteLine("Perimeter: " + Perimeter());
        }

    }
}
