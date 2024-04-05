using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Hotel
    {
        public string Name { get; }
        public string Address { get; }
        public List<HotelRoom> AvailableRooms { get; }
        public Hotel(string name, string address, List<HotelRoom> rooms)
        {
            Name = name;
            Address = address;
            AvailableRooms = rooms;
        }
        public void DisplayAvailableHotelRooms()
        {
            Console.WriteLine($"Hotel {Name} - Available Rooms");
            foreach (HotelRoom room in AvailableRooms)
            {
                if (!room.IsAvailable)
                {
                    Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                }
            }
        }
        public void DisplayBookedRooms()
        {
            Console.WriteLine($"Hotel {Name} - Booked Rooms");
            foreach (HotelRoom room in AvailableRooms)
            {
                if (room.IsAvailable)
                {
                    Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                }
            }
        }
    }
}
