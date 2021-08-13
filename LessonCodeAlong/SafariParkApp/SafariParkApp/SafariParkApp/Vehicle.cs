using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle : IMovable
    {
        public int Position { get; private set; } = 0;
        public int Speed { get; init; }
        public int Capacity { get; set; } = 1;
        private int _numPassengers;
        public int NumPassengers
        {
            get { return _numPassengers; }
            set
            {
                if (value > Capacity)
                {
                    _numPassengers = Capacity;
                }
                else if (value < 0)
                {
                    _numPassengers = 0;
                }
                else
                {
                    _numPassengers = value;
                }


            }
        }
        public virtual string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += times * Speed;
            return $"Moving along {times} times";
        }

        public Vehicle()
        {
            Speed = 10;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            if (capacity < 0)
            {
                capacity = 0;
            }
            Speed = speed;
            Capacity = capacity;
        }
    }
}
