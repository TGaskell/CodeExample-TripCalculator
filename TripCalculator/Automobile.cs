using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripCalculator
{
    class Automobile : Vehicle
    {
        //variables
        private string type;

        //default constructor
        public Automobile()
        {
        }

        //get & set variables into class
        public Automobile(string vehicleType, decimal distance, decimal avgSpeed,
            string type)
            : base(vehicleType, distance, avgSpeed)
        {
            this.Transmission = type;
        }

        public string Transmission
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        //function to display the information
        public override string getVehicleData()
        {
            return base.getVehicleData() + "\n" + "Transmission Type: " + Transmission + "\n";
        }
    }
}
