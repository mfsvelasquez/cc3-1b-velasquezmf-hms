using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Guest: User
    {
        public List<Reservation> Reservations { get; }
        public Guest(string name, string address, string email, long phoneNumber):base(name, address, email, phoneNumber)
        {
            Reservations = new List<Reservation>();
        }
        public void DisplayReservations()
        {
            Console.WriteLine($"List of Reservations of {Name}");
            foreach (Reservation reservation in Reservations)
            {
                Console.WriteLine($"{reservation}");
            }
        }
    }
}
