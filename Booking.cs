using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystemOOPTask
{

    //-------------------- Booking Class ------------------------
    // Represents a booking between a room and a guest
    class Booking
    {
        private ROOM bookedroom;
        private Guest bookingguest;
        private DateTime bookingTime;

        // Read-only property to get booking time
        public DateTime BookingTime
        {
            get { return bookingTime; }
        }

        // Constructor
        public Booking(ROOM room, Guest guest)
        {
            this.bookedroom = room;
            this.bookingguest = guest;
            bookingTime = DateTime.Now;
            Console.WriteLine($"Booking created for Room Number: {room.RoomNumber} and Guest National ID: {guest.NationalID}");
        }

        // Method to confirm booking
        public void ConfirmBooking()
        {
            if (bookedroom.IsBooked)
            {
                Console.WriteLine($"Room {bookedroom.RoomNumber} is already booked.");
            }
            else
            {
                bookedroom.Book();
                bookingTime = DateTime.Now;
                Console.WriteLine($"Booking confirmed for {bookingguest.Name} in room {bookedroom.RoomNumber} at {bookingTime}.");
            }

        }
    }
     
}
