using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_Corona
{
    class Bus : Car
    {
        private int busLine;

        public Bus(int licensePlate, int numOfSeats, int numOfWheels, string owner, int capacity, int busLine) :
            base(licensePlate, numOfSeats, numOfWheels, owner, capacity)
        {
            this.busLine = busLine;
        }

        public int GetBusLine()
        {
            return busLine;
        }

        public void ChangeBusLine(int newLine)
        {
            this.busLine = newLine;
        }

        public override string ToString()
        {
            return base.ToString() + " bus line: " +busLine;
        }
    }
}
