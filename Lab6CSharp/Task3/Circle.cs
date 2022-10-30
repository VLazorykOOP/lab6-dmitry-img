using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task3
{
    internal class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
           _radius = radius;
        }

        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public void Print()
        {
            Console.WriteLine("Circle:");
            Console.WriteLine("Radius: " + _radius);
            Console.WriteLine("Area: " + Area());
            Console.WriteLine("Perimeter: " + Perimeter());
        }
    }
}
