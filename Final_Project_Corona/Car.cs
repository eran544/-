using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project_Corona
{
    class Car : Vehicle
    {
        
        protected int capacity;
        protected double amount;
        protected const double PRICE_PER_LITER = 4.9;
        public Car (int licensePlate, int numOfSeats, int numOfWheels, string owner, int capacity) :
        base(licensePlate, numOfSeats, numOfWheels, owner)
        {
            this.capacity = capacity;
            this.amount = 0;
        }

        public void SetAmount(double amount)
        {
            if (amount <= capacity && amount >= 0)
                this.amount = amount;
        }

        public double GetAmount()
        {
            return amount;
        }

        public int GetCapacity()
        {
            return capacity;
        }

        public virtual double FuelUp()
        { 
            double ret = (capacity - amount) * PRICE_PER_LITER;
            amount = capacity;
            return ret;
        }

        public override string ToString()
        {
            return base.ToString() + " missing for full capacity: " + (capacity-amount);
        }
    }
}
