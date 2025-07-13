using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            get { return name; } //This is the getter:Its function is simply to return the value stored in the variable.
            set //setter: Allows setting a new value for the Name property.
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3) //IsNullOrWhiteSpace -> Checks if the value is empty or just spaces....Length < 3 -> Checks if the name is less than 3 characters long.
                    throw new ArgumentException("Guest name must be at least 3 characters.");
                name = value; //Stores the value in the variable name
            }
        }

       // ---------------------------------------------------
        //Not Why do we use this format?
        //  Because:
       //It prevents the user from entering illogical data, such as a short or blank name.
       //It protects internal data from errors.
       //It implements the encapsulation principle.

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
