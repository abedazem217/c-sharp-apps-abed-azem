using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    class Bus : PublicVehicle
    {
        private readonly int doors;
        private bool bellStop = false;

        public Bus()
        {
        }

        public Bus(int line, int id, int maxSpeed, int seats, int doors) : base(line, id, maxSpeed, seats)
        {
            this.doors = doors;
        }
        public override void SetMaxSpeed(int value)
        {
            if (value < 120 && value > 0)
            {
                MaxSpeed = value;
            }
        }
        public virtual bool CalculateHasRoom()
        {
            if (Math.Round(Seats*1.1)<CurrentPassengers)
                return true;
            return false;
        }

        public virtual void UploadPassengers(int passengers)
        {
            if (CalculateHasRoom() == false)
                return;
            if (passengers + CurrentPassengers <= (int)Math.Round(Seats*1.1))
                CurrentPassengers += passengers;
            else
            {
                CurrentPassengers = Math.Abs(Seats - (CurrentPassengers + passengers));
                RejecetedPassengers = (int)Math.Round(Seats * 1.1);
            }

        }
    }
}

