using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class HotelManagementSystem
    {
        private List<Hotel> hotels = new List<Hotel>();
        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }
        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels: ");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine($"{hotel.Name}, {hotel.Address}");
            }
        }
        public void BookReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime startTime, DateTime endTime)
        {
            Reservation reservation = new Reservation(startTime, endTime, room);
            guest.Reservations.Add(reservation);
        }
        public void DisplayReservationDetails(int reservationNumber)
        {
            foreach (Hotel hotel in hotels)
            {
                foreach (HotelRoom room in hotel.AvailableRooms)
                {
                    foreach (Reservation reservation in room.Reservations)
                    {
                        if (reservation.GetHashCode() == reservationNumber)
                        {
                            Console.WriteLine(reservation);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Reservation not found.");
        }
        public void RegisterUser(User user)
        {

        }
    }
}
