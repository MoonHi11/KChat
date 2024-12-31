using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KayTown.Modelss
{
    public class Chats
    {
        [PrimaryKey]
        public string ChatID { get; set; }
        public bool IsGroup { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
