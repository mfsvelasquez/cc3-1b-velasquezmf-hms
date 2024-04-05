using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class HotelRoom
    {
        public int RoomNumber { get; }
        public RoomStyle Style { get; }
        public decimal Price {  get; }
        public bool IsAvailable {  get; set; }
        public List<Reservation> Reservations { get; }
        public HotelRoom(int roomNumber, RoomStyle style, decimal price)
        {
            RoomNumber = roomNumber;
            Style = style;
            Price = price;
            IsAvailable = false;
            Reservations = new List<Reservation>();
        }
    }
}
