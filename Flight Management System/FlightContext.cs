using Flight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System
{
    internal class FlightContext
    {
    public static List<Passenger>  passengers {  get; set; } =new List<Passenger>();
    public static List<Pilot> pilots { get; set; } = new List<Pilot>();
    public static List<Aircraft> aircrafts { get; set; } =new List<Aircraft>();
    public static List<Flight> flights { get; set; } = new List<Flight>();
        public static List<Booking> bookings { get; set; } = new List<Booking>();
    
    }
}
