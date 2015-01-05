using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TripCalculator
{
    public partial class frmEntry : Form
    {
        public frmEntry()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //validate and set variables
            if (IsValidEntry())
            {
                string vehicleType = cboVehicleSelection.Text;
                int vehicleIndex = cboVehicleSelection.SelectedIndex;
                decimal distance = Convert.ToDecimal(txtDistance.Text);
                string type = cboSelection.Text;
                decimal time = 0m;


                //determine type, speed, and display output
                if (vehicleIndex == 0)
                {
                    decimal speed = 60m;

                    Vehicle veh1 = new Vehicle(vehicleType, distance, speed);
                    Trip trip1 = new Trip(vehicleType, distance, speed, time);
                    Automobile auto1 = new Automobile(vehicleType, distance, speed, type);
                    lblDisplay.Text = auto1.getVehicleData();
                    lblTime.Text = trip1.getTime();
                }
                else if (vehicleIndex == 1)
                {
                    decimal speed = 300m;

                    if (type == "Jet")
                    {
                        speed = 500m;
                    }
                    else
                    {
                        speed = 300m;
                    }

                    Vehicle veh1 = new Vehicle(vehicleType, distance, speed);
                    Trip trip1 = new Trip(vehicleType, distance, speed, time);
                    Plane plane1 = new Plane(vehicleType, distance, speed, type);
                    lblDisplay.Text = plane1.getVehicleData();
                    lblTime.Text = trip1.getTime();
                }
                else if (vehicleIndex == 2)
                {
                    int cars = Convert.ToInt32(txtNumTrolley.Text);
                    decimal speed = 100m;

                    if (cars < 20)
                    {
                        speed = 70m;
                    }
                    else
                    {
                        speed = 100m;
                    }

                    Vehicle veh1 = new Vehicle(vehicleType, distance, speed);
                    Trip trip1 = new Trip(vehicleType, distance, speed, time);
                    Train train1 = new Train(vehicleType, distance, speed, cars);
                    lblDisplay.Text = train1.getVehicleData();
                    lblTime.Text = trip1.getTime();
                }
            }
        }

        private void cboVehicleSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set variable for index value
            int vehicleIndex = cboVehicleSelection.SelectedIndex;

            //determine type and set dropdown boxes & labels
            if (vehicleIndex == 0)
            {
                cboSelection.Visible = true;
                lblSelection.Visible = true;
                lblTime.Visible = true;
                lblSelection.Text = "Select Transmission";
                string[] trans = { "Manual", "Automatic" };
                foreach (string tran in trans)
                {
                    cboSelection.Items.Add(tran);
                }
            }
            else if (vehicleIndex == 1)
            {
                cboSelection.Visible = true;
                lblSelection.Visible = true;
                lblTime.Visible = true;
                lblSelection.Text = "Select Engine";
                string[] engines = { "Jet", "Turbo" };
                foreach (string engine in engines)
                {
                    cboSelection.Items.Add(engine);
                }
            }
            else if (vehicleIndex == 2)
            {
                lblNumTrolley.Visible = true;
                lblTime.Visible = true;
                txtNumTrolley.Visible = true;
            }
        }
        //validation method
        private bool IsValidEntry()
        {
            return Validator.IsPresent(txtDistance) &&
                   Validator.IsDecimal(txtDistance);
        }
    }
}
