using Lab6CSharp.Task1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task1
{
    //implement ICloneable interface
    
    class ExpressTrain : Train, ITrain, IEnumerable, ICloneable
    {
        private int _passengersCount;

        public ExpressTrain(int passengersCount, int carriagesCount, double maxVelocity, int seatsCount) : base(carriagesCount, maxVelocity, seatsCount)
        {
            Console.WriteLine("public ExpressTrain(int passengersCount, int carriagesCount, double maxVelocity, int seatsCount) : base(carriagesCount, maxVelocity, seatsCount)");
            _passengersCount = passengersCount;
        }
        public ExpressTrain(int carriagesCount, double maxVelocity, int seatsCount) : this(0, carriagesCount, maxVelocity, seatsCount)
        {
            Console.WriteLine("public ExpressTrain(int carriagesCount, double maxVelocity, int seatsCount) : this(0, carriagesCount, maxVelocity, seatsCount)");
        }
        public ExpressTrain() : this(0,0,0)
        {
            Console.WriteLine("public ExpressTrain() : this(0,0,0)");
        }
        public override void Show()
        {
            Console.Write("Express ");
            base.Show();
            Console.WriteLine("Passengers count: " + _passengersCount);
        }

        public IEnumerator GetEnumerator()
        {
            yield return _passengersCount;
            yield return _carriagesCount;
            yield return _maxVelocity;
            yield return _seatsCount;
            yield break;
        }

        ~ExpressTrain()
        {
            Console.WriteLine("~ExpressTrain()");
        }
    }
}
