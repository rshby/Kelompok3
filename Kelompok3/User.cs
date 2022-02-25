using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok3
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string inputFirstName, string inputLastName, string inputPassword)
        {
            FirstName = inputFirstName;
            LastName = inputLastName;
            Password = inputPassword;
            Username = inputFirstName.Substring(0, 2) + inputLastName.Substring(0, 2);
        }
    }
}