using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Reservation
    {
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public HotelRoom Room { get; }
        public Reservation(DateTime startTime, DateTime endTime, HotelRoom room)
        {
            StartTime = startTime;
            EndTime = endTime;
            Room = room;
            room.IsAvailable = true;
        }
        public override string ToString()
        {
            TimeSpan duration = EndTime - StartTime;
            decimal total = duration.Days * Room.Price;
            return $"Start Time: {StartTime}, End Time: {EndTime}, Duration: {duration.Days}, Total: {total}";
        }
    }
}
