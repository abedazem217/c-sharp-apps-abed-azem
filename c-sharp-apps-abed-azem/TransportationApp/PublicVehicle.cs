using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_abed_azem.TransportationApp
{
    class PublicVehicle
    {
        private int line = 0;
        private int id = 0;
        private int maxSpeed = 0;
        private int seats = 0;
        private int currentPassengers = 0;
        private bool hasRoom = true;
        private int RejecetedPassengers;

        public PublicVehicle()
        {
        }

        public PublicVehicle(int line, int id)
        {
            this.line = line;
            this.id = id;
        }

        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            this.maxSpeed = maxSpeed;
            this.seats = seats;
        }

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }
        public int RejecetedPassengers { get => RejecetedPassengers; set => RejecetedPassengers = value; }

        public virtual void SetMaxSpeed(int value)
        {
            if (value <40 && value > 0)
            {
                maxSpeed = value;
            }
        }
        public virtual bool  CalculateHasRoom()
        {
            if (seats <= currentPassengers)
                return true;
            return false;
        }

        public virtual void UploadPassengers(int passengers)
        {
            if (CalculateHasRoom() == false)
                return;
            if (passengers + currentPassengers <= seats)
                currentPassengers += passengers;
            else
            {
                currentPassengers = Math.Abs(seats - (currentPassengers + passengers));
                RejecetedPassengers = seats; 
            }

        }
        public override string ToString()
        {
            return $"line:{line}, id:{id},maxspeed:{maxSpeed},seats:{seats}";
        }
    }

}
