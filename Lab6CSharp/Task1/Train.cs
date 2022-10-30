using Lab6CSharp.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task1
{
    class Train : Transport, ITrain, ICloneable
    { 
        protected int _carriagesCount;

        public Train(int carriagesCount, double maxVelocity, int seatsCount) : base(maxVelocity, seatsCount)
        {
            Console.WriteLine("public Train(int carriagesCount, double maxVelocity, int seatsCount) : base(maxVelocity, seatsCount)");
            _carriagesCount = carriagesCount;
        }
        public Train(double maxVelocity, int seatsCount) : this(0, maxVelocity, seatsCount)
        {
            Console.WriteLine("public Train(double maxVelocity, int seatsCount) : this(0, maxVelocity, seatsCount)");
        }
        public Train() : this(0, 0)
        {
            Console.WriteLine("public Train() : this(0, 0)");
        }
        public override void Show()
        {
            Console.WriteLine("Train:");
            base.Show();
            Console.WriteLine("Carriages count: " + _carriagesCount);
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        ~Train()
        {
            Console.WriteLine("~Train()");
        }
    }
}
