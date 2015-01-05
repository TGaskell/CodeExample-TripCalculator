using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripCalculator
{
    class Vehicle
    {
        //variables
        private string vehicleType;
        private decimal distance;
        private decimal avgSpeed;

        //default constructor
        public Vehicle()
        {
        }

        //get & set variables into class
        public Vehicle(string vehicleType, decimal distance, decimal avgSpeed)
        {
            this.VehicleType = vehicleType;
            this.Distance = distance;
            this.AvgSpeed = avgSpeed;
        }

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
            }
        }

        public decimal Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public decimal AvgSpeed
        {
            get
            {
                return avgSpeed;
            }
            set
            {
                avgSpeed = value;
            }
        }

        //function to display the information in the form
        public virtual string getVehicleData()
        {
            return "Vehicle Type: " + VehicleType + "\n" + "Distance: " + Distance + "\n" + "Average Speed: " + AvgSpeed;
        }
    }
}
