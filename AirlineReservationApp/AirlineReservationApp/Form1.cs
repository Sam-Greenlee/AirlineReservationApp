/*
 * Author: Samuel Greenlee
 * Project: Assignment Four
 * Date  : March 11, 2020
 * Desc  : Makes a reservation for the user for one of two planes
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationApp
{
    public partial class frmAirlineReservationApp : Form
    {
        public frmAirlineReservationApp()
        {
            InitializeComponent();
        }
        //Declare the currentFlight object and set to null for further use
        Flight currentFlight = null;

        //Declare preset flights
        Flight flight1 = new Flight("Cessna", "10:00AM", "Denver", 4, 3);
        Flight flight2 = new Flight("Piper", "2:00PM", "Kansas City", 3, 2);

        private void frmAirlineReservationApp_Load(object sender, EventArgs e)
        {
            //Set default radio button settings
            RadioButtonSettings();
        }

        //This method sets default radio button settings
        public void RadioButtonSettings()
        {
            rdoDenver.Checked = true;
            rdoKansas.Checked = false;
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            //Declare variables
            int seat;
            string passenger;

            //This is the method starts the configeration that does the data validation
            if (DataValid() == true)
            { 
                //Gather user input
                seat = Convert.ToInt16(txtSeat.Text);
                passenger = txtPassenger.Text;

                //Add resevation to its correct spot
                AddReservation(seat, passenger);
            }
        }

        //These are the methods that configure the data validation
        private bool DataValid()
        {
            return
                IsPresent(txtPassenger, "Passenger")&&
                IsInt16(txtSeat, "Seat");
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool IsInt16(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " mustbe a integer ", "Entry Error");
                label2.Focus();
                return false;
            }
        }

        //This method adds the user's reservation to the correct spot
        private void AddReservation(int seat, string passenger)
        {
            //Add Reservation based on flight destination selected
            currentFlight.MakeReservation(seat, passenger);

            //Display the current info for the listbox
            ShowSeatChart(currentFlight);
        }

        //This is event handler that handles rdoDenver
        //This method displays what is needed to be displayed for the denver flight in the correct texboxes
        private void rdoDenver_CheckedChanged(object sender, EventArgs e)
        {
            //Clear input boxes
            ClearTextBoxes();

            //Displays the user info for the Denver flight
            currentFlight = flight1;
            txtDestination.Text = flight1.Destination;
            txtDeparture.Text = flight1.DepartureTime;
            txtPlane.Text = flight1.PlaneType;

            //Display the available seats for the denver flight
            ShowSeatChart(currentFlight);
        }

        //This is event handler that handles rdoKansas
        //This method displays what is needed to be displayed for the kansas flight in the correct texboxes
        private void rdoKansas_CheckedChanged(object sender, EventArgs e)
        {
            //Clear input boxes
            ClearTextBoxes();

            //Displays the user info for the kansas flight
            currentFlight = flight2;
            txtDestination.Text = flight2.Destination;
            txtDeparture.Text = flight2.DepartureTime;
            txtPlane.Text = flight2.PlaneType;

            //Display the available seats for the kansas flight
            ShowSeatChart(currentFlight);

        }

        //This method clears the input boxes
        private void ClearTextBoxes()
        {
            txtDestination.Clear();
            txtDeparture.Clear();
            txtPlane.Clear();
        }

        //This method will show the available seats in the list box.
        private void ShowSeatChart(Flight currentFlight)
        {
            //Clear the listbox
            lstFlightSeats.Items.Clear();

            //Print the seatChart
            string[] seating = currentFlight.SeatChart;

            for(int i = 0; i <= seating.GetUpperBound(0); i++)
            {
                lstFlightSeats.Items.Add("Seat " + (i + 1) + " " + seating[i]);
            }
        }
    }
}
