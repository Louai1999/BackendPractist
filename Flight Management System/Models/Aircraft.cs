using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Management_System.Models
{
    public class Aircraft
    {
    public int aircraftId {  get; set; } // System Generated
    public string model {  get; set; } // user inpurt
    public int totalSeats { get; set; } // Calculated
    public bool isOperational { get; set; } //Default Value

    }
}
