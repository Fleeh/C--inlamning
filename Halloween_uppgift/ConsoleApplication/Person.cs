using Discounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Contact
    {

        public Contact(string Firstname, string Lastname, string email)
        {
            FirstName = Firstname;
            LastName = Lastname;
            Email = email;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Utklädnad { get; set; }

    }
}

