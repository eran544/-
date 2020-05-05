using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_Corona
{
    class Bicycle : Vehicle
    {
        private const double MAX_PRECENTAGE = 100;
        private const int PERCENTAGE_PER_KM = 5;
        private const double PERCENTAGE_PER_MINUTES = 3;
        private double currentPrecentage;

        public Bicycle(int licensePlate, int numOfSeats, int numOfWheels, string owner) :
            base (licensePlate, numOfSeats, numOfWheels, owner)
        {
            currentPrecentage = 50;
        }

        public double GetCurrentPrecentage()
        {
            return currentPrecentage;
        }

        public void Ride(int km)
        {
            currentPrecentage = Math.Max(0, currentPrecentage - (PERCENTAGE_PER_KM * km));
        }

        public void Charge (int minutes)
        {
            currentPrecentage = Math.Min(MAX_PRECENTAGE, currentPrecentage + (PERCENTAGE_PER_MINUTES * minutes));
        }

        public override string ToString()
        {
            return base.ToString() + " current precentage: " + currentPrecentage;
        }
    }
}
