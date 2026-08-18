using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    public class Booking
    {
    public int bookingId {  get; set; } // System generated
    public int passengerId { get; set; } // user input
    public int flightId { get; set; } // user input
    public string seatNumber { get; set; } // System generated
    public string bookingDate { get; set; } // Syestem generated
    public decimal totalPrice { get; set; } // calculated
    public string status { get; set; } // default value

    }
}
