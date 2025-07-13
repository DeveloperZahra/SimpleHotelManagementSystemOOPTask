namespace SimpleHotelManagementSystemOOPTask
{
    //-------------------- Program Class ------------------------
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            HotelUtils.PrintWelcomeMessage();

            // Create one room and one guest
            ROOM room1 = new ROOM(101);
            Guest guest1 = new Guest("Ali", "987654321");
            guest1.Password = "Secret123";

            // Display room status before booking
            Console.WriteLine($"Before booking: Room {room1.RoomNumber} booked? {room1.IsBooked}");

            // Create a booking and confirm it
            Booking booking = new Booking(room1, guest1);
            booking.ConfirmBooking();

            // Display room status after booking
            Console.WriteLine($"After booking: Room {room1.RoomNumber} booked? {room1.IsBooked}");

            // Show total rooms created (static)
            Console.WriteLine($"Total rooms created: {ROOM.GetRoomCount()}");

            // Check room availability using static method
            Console.WriteLine($"Is Room {room1.RoomNumber} available? {HotelUtils.IsRoomAvailable(room1)}");
        }


    }
}
