using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripCalculator
{
    class Train : Vehicle
    {
        //variables
        private int cars;

        //default constructor
        public Train()
        {
        }

        //get & set variables into class
        public Train(string vehicleType, decimal distance, decimal avgSpeed,
            int cars)
            : base(vehicleType, distance, avgSpeed)
        {
            this.Trolley = cars;
        }

        public int Trolley
        {
            get
            {
                return cars;
            }
            set
            {
                cars = value;
            }
        }

        //function to display the information
        public override string getVehicleData()
        {
            return base.getVehicleData() + "\n" + "Trolley Cars: " + Trolley;
        }
    }
}
