using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystemOOPTask
{
    // Class definition for Guest
    internal class Guest
    {
        
        //class Auto-property (get , set)
        public string Name { get; set; }
        public int NationalID { get; set; }
   

    // Constructor... Allows creating a new Guest object and specifying the name and national number directly.
    public Guest(string name, string nationalId)
        {
            Name = name;
            NationalID = NationalID;
        }




    }
}
