using Flight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System
{
    internal class FlightContext
    {
    public static List<Passenger>  passengers {  get; set; }
    public static List<Pilot> pilots { get; set; }
    public static List<Aircraft> aircrafts { get; set; }
    public static List<Flight> flights { get; set; }
    public static List<Booking> bookings { get; set; }
    
    }
}
