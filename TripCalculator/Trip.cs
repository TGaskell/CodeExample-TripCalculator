using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripCalculator
{
    class Trip : Vehicle
    {
        //variables
       public decimal time;

       //default constructor
        public Trip () 
        {
        }

        //calculate time
        public Trip(string vehicleType, decimal distance, decimal avgSpeed, decimal time)
            : base(vehicleType, distance, avgSpeed) 
        {
            this.Time = time;
        }

        //get & set the time
        public decimal Time
        {
            get
            {
                return time;
            }
            set
            {
                time = Distance / AvgSpeed;
            }
        }

        public string getTime()
        {
            return "Time: " + Time.ToString("n2");
        }
    }
}
