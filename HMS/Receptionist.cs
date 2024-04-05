using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class Receptionist : User
    {
        public Receptionist(string name, string address, string email, long phoneNumber):base(name, address, email, phoneNumber)
        {
       
        }
        public void BookReservation(Guest guest, Reservation reservation)
        {
            guest.Reservations.Add(reservation);
        }
    }
}
