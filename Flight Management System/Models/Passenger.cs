using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    public class Passenger
    {
        public int passengerId {  get; set; } // System generated
        public string passengerName { get; set; } // user input
        public string passengerEmail { get; set; } // user input
        public double passengerPhone { get; set; } // user input
        public string passportNumber { get; set; } // user input
        public string nationality { get; set; } // From List

    }
}
