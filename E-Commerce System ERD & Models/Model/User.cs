using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class User
    {
        public int userId { get; set; }// system generated 
        public string userName { get; set; } // user input
        public string email { get; set; } // user input
        public string passwordHash { get; set; } // user input 
        public string fullName { get; set; } // user input 
        public string phoneNember { get; set; } // user input 
        public string address { get; set; } // user input
        public DateTime registrationDate { get; set; }//calculated 
        public bool isActive { get; set;  } // Defult value 





    }
}
