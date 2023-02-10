/*
 * Author: Samuel Greenlee
 * Project: Assignment Four
 * Date  : March 11, 2020
 * Desc  : Makes a reservation for the user for one of two planes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationApp
{
    class Flight
    {
        //Attibutes of Fields
        private string planeType;
        private string departureTime;
        private string destination;
        private int rows;
        private int seats;
        private string[] seatChart;

        //Constructors
        public Flight(string thePlaneType, string theDepartureTime, string theDestination, int theRows, int theSeats)
        {
            PlaneType = thePlaneType;
            DepartureTime = theDepartureTime;
            Destination = theDestination;
            Rows = theRows;
            seats = theSeats;

            SeatChart = new String[Rows * Seats];

            for(int i = 0; i <= SeatChart.GetUpperBound(0); i++)
            {
                SeatChart[i] = "Open";
            }
        }

        public string PlaneType
        {
            get { return planeType; }
            set { planeType = value;  }
        }

        public string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public string Destination
        {
            get { return destination;  }
            set { destination = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        //This is the get and set method for the string seatChart array
        public string[] SeatChart
        {
            get { return seatChart; }
            set { seatChart = value; }
        }

        //Make a reservation 
        public void MakeReservation(int seat, string passengerName)
        {
            if (seat > 0 && seat <= SeatChart.GetUpperBound(0)+1)
            {
                if(SeatChart[seat - 1] == "Open")
                {
                    SeatChart[seat - 1] = passengerName;
                }
            }
        }

        public bool IsFull()
        {
            bool full = true;
            for (int i = 0; i <= SeatChart.GetUpperBound(0); i++)
            {
                if (SeatChart[i] == "Open")
                {
                    full = false;
                    i = SeatChart.GetUpperBound(0);
                }
            }
            return full;
        }
    }
}
