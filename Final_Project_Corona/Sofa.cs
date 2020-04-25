using System;
using System.Text;

namespace Final_Project_Corona
{
    class Sofa
    {
        //Enter fields as requested in Q3a
        private string model;
        private string country;
        private double price;


        //Complete those methods as requested in the assignment

        public Sofa(string model, string country, double price)
        {
            this.model = model;
            this.country = country;
            this.price = price;
        }

        public string GetModel()
        {
            return this.model;
        }

        public string GetCountry()
        {
            return this.country;
        }
        public double GetPrice()
        {
            return this.price;
        }
    }
}
