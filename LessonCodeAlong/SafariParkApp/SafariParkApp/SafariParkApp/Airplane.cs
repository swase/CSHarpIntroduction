using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    class Airplane : Vehicle
    {
        private string _airline = "";
        public int Altitude { get; set; } = 0;


        public Airplane(int capacity, string airline) : base(capacity)
        {
            this._airline = airline;
        }
        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            this._airline = airline;
        }
        public override string ToString()
        {
            return $"Thank you for flying {this._airline}: {base.ToString()} capacity: {this.Capacity} " +
                $"passengers: {this.NumPassengers} " +
                $"speed: {this.Speed} position: {this.Position} altitude: {this.Altitude}";
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            if (Altitude - distance < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Altitude -= distance;
            }
            
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} metres";
        }

    }
}
