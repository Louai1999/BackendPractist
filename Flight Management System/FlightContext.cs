using Flight_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System
{
    internal class FlightContext
    {
    public List<Passenger>  passengers {  get; set; }
    public List<Pilot> pilots { get; set; }
    public List<Aircraft> aircrafts { get; set; }
    public List<Flight> flights { get; set; }
    public List<Booking> bookings { get; set; }
    
    }
}
