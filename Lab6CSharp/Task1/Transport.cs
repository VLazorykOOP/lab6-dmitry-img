using Lab6CSharp.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task1
{
    abstract class Transport : IShowable
    {

        protected double _maxVelocity;
        protected int _seatsCount;

        public Transport(double maxVelocity, int seatsCount)
        {
            Console.WriteLine("public Transport(double maxVelocity, int seatsCount)");
            _maxVelocity = maxVelocity;
            _seatsCount = seatsCount;
        }
        public Transport(double value)
        {
            Console.WriteLine("public Transport(double value)");
            _maxVelocity = value;
            _seatsCount = (int)value;
        }
        public Transport()
        {
            Console.WriteLine("public Transport()");
            _maxVelocity = 0;
            _seatsCount = 0;
        }
        public virtual void Show(){
            Console.WriteLine("Max velocity: " + _maxVelocity);
            Console.WriteLine("Seats count: " + _seatsCount);
        }
        ~Transport()
        {
            Console.WriteLine("~Transport()");
        }
    }
}
