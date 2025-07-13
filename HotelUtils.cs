using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystemOOPTask
{
    //-------------------- HotelUtils Class ------------------------
    // Static class with utility methods for the hotel
    static class HotelUtils
    {
        // Prints a welcome message
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to our Hotel! We hope you enjoy your stay.");
        }

        // Checks if a room is available
        public static bool IsRoomAvailable(ROOM room)
        {
            if (room.IsBooked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }














}

