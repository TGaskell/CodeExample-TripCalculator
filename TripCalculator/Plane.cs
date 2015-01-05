using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripCalculator
{
    class Plane : Vehicle
    {
        //variables
        private string type;

        //default constructor
        public Plane()
        {
        }

        //get & set variables into class
        public Plane(string vehicleType, decimal distance, decimal avgSpeed,
            string type)
            : base(vehicleType, distance, avgSpeed)
        {
            this.Engine = type;
        }

        public string Engine
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

        //function to display the information in the form
        public override string getVehicleData()
        {
            return base.getVehicleData() + "\n" + "Engine Type: " + Engine;
        }
    }
}
