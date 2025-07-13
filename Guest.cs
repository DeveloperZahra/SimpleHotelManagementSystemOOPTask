using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystemOOPTask
{
    //-------------------- Guest Class ------------------------
    // Represents a hotel guest with name, ID, and password
    public class Guest
    {
        private string name;
        private string nationalID;
        private string password;

        // Auto-properties with validation
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new ArgumentException("Guest name must be at least 3 characters.");
                name = value;
            }
        }


        public string NationalID
        {
            get { return nationalID; } //Returns the current value of the nationalID.
            set //It checks that the value is not empty, and then stores it in nationalID.
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("National ID cannot be empty.");
                nationalID = value;
            }
        }

        // Write-only property for password
        public string Password
        {
            set { password = value; }
        }

        // Constructor
        public Guest(string name, string nationalID)
        {
            Name = name;
            NationalID = nationalID;
        }

    }
}
