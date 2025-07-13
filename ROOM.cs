using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystemOOPTask
{
    // Class definition for Room
    internal class ROOM
    {
        //Fields 
        private int roomNumber;
        private bool isBooked;


        //Constructors 
        public  ROOM(int Number)

        {
            roomNumber = Number;
            isBooked = false; // // By default, the room is not booked

        }

        // Property to get the room number (Read-only)
        public int RoomNumber
        {
            get { return roomNumber; }
        }

        // Property to get whether the room is booked (Read-only)
        public bool IsBooked
        {
            get { return isBooked; }
        
        }

        // Method to book the room

        public void BookRoom()

        {
           isBooked = true;
        }

        // Method to cancel the booking
        public void CancelBooking()
        {
            isBooked = false;
        }

    }





}
