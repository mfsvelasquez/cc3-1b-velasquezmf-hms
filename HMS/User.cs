using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public class User
    {
        public string Name { get; }
        public string Address { get; }
        public string Email { get; }
        public long PhoneNumber { get; }
        public User(string name, string address, string email, long phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
