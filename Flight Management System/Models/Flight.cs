using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    public class Flight
    {
    public int flightId {  get; set; } // System generated
    public string flightcode { get; set; } //System generated
        public int aircraftId { get; set; } // user input
    public int pilotId { get; set; } // user input
    public string origin { get; set; } // user input
    public string destination { get; set; } // user input 
    public string departureDate { get; set; } // user input
    public string departureTime { get; set; } // user input
    public decimal ticketPrice { get; set; } //calculated 
    public int availableSeats { get; set; } // default value
    public string status { get; set; } // default value
    }
}
