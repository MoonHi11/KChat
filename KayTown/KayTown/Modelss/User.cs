using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KayTown.Modelss
{
    public class User
    {
        [PrimaryKey]
        public string UserID { get; set; }
        public string UserName { get; set; }
        public int PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
        public string LastSeen {get; set;}
        public string AboutYou { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; } 

    }
}
