using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystemOOPTask
{
    //-------------------- Room Class ------------------------
    // Represents a hotel room with room number and booking status
    internal class ROOM
    {
        //Fields 
        private int roomNumber;
        private bool isBooked;
        private static int roomCount = 0; // Static field to track total rooms created

        // Constructor with validation
        public ROOM(int number)
        {
            if (number < 100)
                throw new ArgumentException("Room number must be 100 or above.");
            roomNumber = number;
            isBooked = false;
            roomCount++;
        }

       
        // Read-only property to get room number
        public int RoomNumber
        {
            get { return roomNumber; }
        }

        // Read-only property to check if room is booked
        public bool IsBooked
        {
            get { return isBooked; }
        }

        // Method to book the room
        public void Book()
        {
            isBooked = true;
        }

        // Method to free the room
        public void Free()
        {
            isBooked = false;
        }

        // Static method to get total number of rooms created
        public static int GetRoomCount()
        {
            return roomCount;
        }

        
    }





}
