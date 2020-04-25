using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_Corona
{
    abstract class Vehicle
    {
        protected int licensePlate;
        protected int numOfSeats;
        protected int numOfWheels;
        protected string owner;

        public Vehicle(int licensePlate, int numOfSeats, int numOfWheels, string owner)
        {
            this.licensePlate = licensePlate;
            this.numOfSeats = numOfSeats;
            this.numOfWheels = numOfWheels;
            this.owner = owner;
        }


        public int GetLicensePlate()
        {
            return this.licensePlate;
        }
        public int GetNumOfSeats()
        {
            return this.numOfSeats;
        }
        public int GetNumOfWheels()
        {
            return this.numOfWheels;
        }
        public void SellVehicle(string newOwner)
        {
            this.owner = newOwner;
        }

        public string GetOwner()
        {
            return owner;
        }

        public override string ToString()
        {
            return ("license Plate: " + licensePlate + " num of seats: " + numOfSeats
                + " num of wheels: " + numOfWheels + " Owner: " + owner);
        }

    }
}
