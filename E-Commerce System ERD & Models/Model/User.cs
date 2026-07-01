using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public string fullName { get; set; }
        public string phoneNember { get; set; }
        public string address { get; set; }
        public DateTime registrationDate { get; set; }
        public bool isActive { get; set;  }





    }
}
